package com.koushikdutta.monodalvikbridge;

import java.io.IOException;
import java.io.InvalidClassException;
import java.io.UnsupportedEncodingException;
import java.lang.reflect.Method;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;
import java.security.InvalidParameterException;
import java.util.Hashtable;
import java.util.Map;

import android.os.Handler;
import android.util.Log;

class ByteBufferOutputStream
{
	ByteBuffer mBuffer = ByteBuffer.allocate(256);
	
	void setByteArray(byte[] buffer)
	{
		mBuffer = ByteBuffer.wrap(buffer);
		mBuffer.order(ByteOrder.nativeOrder());
	}
	
	ByteBuffer getByteBuffer()
	{
		return mBuffer;
	}
	
	void ensure(int space)
	{
		if (mBuffer.remaining() < space)
		{
			ByteBuffer newBuffer = ByteBuffer.allocate(mBuffer.capacity() * 2);
			newBuffer.order(ByteOrder.nativeOrder());
			newBuffer.put(mBuffer.array(), 0, mBuffer.position());
			mBuffer = newBuffer;
		}
	}
	
	public ByteBufferOutputStream()
	{
		mBuffer.order(ByteOrder.nativeOrder());
	}
	
	public void writeChar(char value)
	{
		ensure(1);
		mBuffer.putChar(value);
	}
	
	public void write(byte value)
	{
		ensure(1);
		mBuffer.put(value);
	}
	
	public void writeShort(short value)
	{
		ensure(2);
		mBuffer.putShort(value);
	}
	
	public void writeInt(int value)
	{
		ensure(4);
		mBuffer.putInt(value);
	}
	
	public void writeLong(long value)
	{
		ensure(8);
		mBuffer.putLong(value);
	}
	
	public void writeFloat(float value)
	{
		ensure(4);
		mBuffer.putFloat(value);
	}
	
	public void writeDouble(double value)
	{
		ensure(8);
		mBuffer.putDouble(value);
	}
	
	public void writeBoolean(boolean value)
	{
		ensure(1);
		write(value ? (byte)1 : (byte)0);
	}
	
	public void write(byte[] value)
	{
		ensure(value.length);
		mBuffer.put(value);
	}
	
	public void writeString(String value)
	{
		if (value == null)
		{
			writeInt(-1);
		}
		else
		{
			writeInt(value.length());
			try
			{
				write(value.getBytes("ASCII"));
			}
			catch (UnsupportedEncodingException e)
			{
			}
		}	
	}
	
	public void rewind()
	{
		mBuffer.rewind();
	}
	
	public byte[] toByteArray()
	{
		return mBuffer.array();
	}
	
	public int size()
	{
		return mBuffer.position();
	}
}

public final class MonoBridge
{
	public static final byte Default = 0;
	public static final byte Char = 1;
	public static final byte Byte = 2;
	public static final byte Int16 = 3;
	public static final byte UInt16 = 4;
	public static final byte Int32 = 5;
	public static final byte UInt32 = 6;
	public static final byte Int64 = 7;
	public static final byte UInt64 = 8;
	public static final byte Single = 9;
	public static final byte Double = 10;
	public static final byte Boolean = 11;
	public static final byte String = 12;
	public static final byte MonoObject = 13;
	public static final byte JavaObject = 14;
	public static final byte Void = 15;

	static Hashtable<Class, Byte> myConversions = new Hashtable<Class, Byte>();
	static Hashtable<Byte, Class> myUnconversions = new Hashtable<Byte, Class>();
	static Handler mHandler = new Handler();
		
    static ThreadLocal<ByteBufferOutputStream> myWriter = new ThreadLocal<ByteBufferOutputStream>()
    {
    	@Override
    	protected ByteBufferOutputStream initialValue()
    	{
    		return new ByteBufferOutputStream();
    	}
    };        
    static ThreadLocal<ByteBuffer> myReader = new ThreadLocal<ByteBuffer>()
    {
    	@Override
    	protected ByteBuffer initialValue()
    	{
    		return null;
    	}
    };


	interface SerializeHandler { void Convert(Object o) throws IOException; }
	interface DeserializeHandler { Object Convert(); }

	static SerializeHandler[] myConvertHandlers = new SerializeHandler[Void + 1];
	static DeserializeHandler[] myUnconvertHandlers = new DeserializeHandler[Void + 1];
	
	static String deserializeString()
	{
		ByteBuffer b = myReader.get();
		int length =b.getInt();
		if (length == -1)
			return null;
		int pos = b.position();
		byte[] array = b.array();
		String ret = new String(array, pos, length);
		b.position(pos + length);
		return ret;
	}
	
	static Object mSignal = new Object();
	static boolean mInitialized = false;

	static
	{
		DebugLog("Initializing DalvikBridge");
		System.load("/data/data/com.koushikdutta.mono/libmono.so");
		
		myConversions.put(Character.class, Char);
        myConversions.put(Byte.class, Byte);
        myConversions.put(Short.class, Int16);
        myConversions.put(Integer.class, Int32);
        myConversions.put(Long.class, Int64);
        myConversions.put(Float.class, Single);
        myConversions.put(Double.class, Double);
        myConversions.put(Boolean.class, Boolean);
        myConversions.put(String.class, String);
        myConversions.put(MonoObject.class, MonoObject);
        myConversions.put(void.class, Void);
       
        for(Map.Entry<Class, Byte>pair: myConversions.entrySet())
        {
        	myUnconversions.put(pair.getValue(), pair.getKey());
        }

        myConvertHandlers[Char] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeChar((Character)o); } };
        myConvertHandlers[Byte] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().write((Byte)o); } };
        myConvertHandlers[Int16] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeShort((Short)o); } };
        myConvertHandlers[Int32] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeInt((Integer)o); } };
        myConvertHandlers[Int64] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeLong((Long)o); } };
        myConvertHandlers[Single] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeFloat((Float)o); } };
        myConvertHandlers[Double] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeDouble((Double)o); } };
        myConvertHandlers[Boolean] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeBoolean((Boolean)o); } };
        myConvertHandlers[String] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeString((String)o); } };
        myConvertHandlers[MonoObject] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myWriter.get().writeInt(((MonoObject)o).myObjectId); } };
        myConvertHandlers[JavaObject] = new  SerializeHandler() { public void Convert(Object o) throws IOException { myMonoReferences.put(myMonoReferenceCounter, o); myWriter.get().writeInt(myMonoReferenceCounter++); } };
        
        
        myUnconvertHandlers[Char] = new DeserializeHandler() { public Object Convert() { return myReader.get().getChar(); } };
        myUnconvertHandlers[Byte] = new DeserializeHandler() { public Object Convert() { return myReader.get().get(); } };
        myUnconvertHandlers[Int16] = new DeserializeHandler() { public Object Convert() { return myReader.get().getShort(); } };
        myUnconvertHandlers[Int32] = new DeserializeHandler() { public Object Convert() { return myReader.get().getInt(); } };
        myUnconvertHandlers[Int64] = new DeserializeHandler() { public Object Convert() { return myReader.get().getLong(); } };
        myUnconvertHandlers[Single] = new DeserializeHandler() { public Object Convert() { return myReader.get().getFloat(); } };
        myUnconvertHandlers[Double] = new DeserializeHandler() { public Object Convert() { return myReader.get().getDouble(); } };
        myUnconvertHandlers[Boolean] = new DeserializeHandler() { public Object Convert() { return myReader.get().get() == 0 ? false : true; } };
        myUnconvertHandlers[String] = new DeserializeHandler() { public Object Convert() { return deserializeString(); } };
        myUnconvertHandlers[MonoObject] = new DeserializeHandler() { public Object Convert() { int id = myReader.get().getInt(); if (id <= 0) return null; return new MonoObject(id); } };
        myUnconvertHandlers[JavaObject] = new DeserializeHandler() { public Object Convert() {  int id = myReader.get().getInt(); if (id <= 0) return null; return myMonoReferences.get(id); } };
        
		new Thread(new Runnable()
		{
			public void run()
			{
				DebugLog("Calling initializeRuntime");
				initializeRuntime();
			}	
		}).start();
	}
	
	public static boolean isInitialized()
	{
		return mInitialized;
	}
	
	static native void getInvokeBuffer(byte[] buffer,  int returnBufferLength);
	static native void setReturnBuffer(byte[] value, int returnBufferLength);
	
	static void DebugLog(String format, Object... args)
	{
		String message = java.lang.String.format(format, args);
		Log.i("MonoBridge", message);
	}
	

    static boolean matchesSignature(String methodName, Class[] parameterTypes, Class returnType, Method method)
    {
        if (!method.getName().equals(methodName))
        {
            //DebugLog("Method name does not match %s vs %s", methodName, method.getName());
            return false;
        }
        // if it is void, don't bother with the method return check
        if (!returnType.equals(method.getReturnType()) && !returnType.equals(void.class))
        {
            //DebugLog("Return type does not match %s vs %s", returnType, method.getReturnType());
            return false;
        }
        Class[] parameterInfos = method.getParameterTypes();
        if (parameterInfos.length != parameterTypes.length)
        {
            //DebugLog("Parameter count does not match %d vs %d", parameterTypes.length, parameterInfos.length);
            return false;
        }
        boolean match = true;
        for (int i = 0; i < parameterTypes.length; i++)
        {
            // if we don't know the type, that means it is null and not explicitly provided, just ignore it.
            // check for multiple matches later (ambiguous matches)
            if (parameterTypes[i] == null)
                continue;
            if (!parameterTypes[i].equals(parameterInfos[i]))
            {
                DebugLog("Parameter type %d does not match %s vs %s", i, parameterTypes[i].toString(), parameterInfos[i].toString());
                match = false;
                break;
            }
        }
        return match;
    }
	
	static void handleInvoke(int invokeBufferLength)
	{
		try
		{
			DebugLog("Handling Invoke from Mono");
			ByteBuffer reader = ensureBufferLength(invokeBufferLength);
			reader.rewind();
			getInvokeBuffer(reader.array(), invokeBufferLength);
			
			// eat the invoke buffer length
			deserializeObject(Int32);
			String fullyQualifiedName = (String)deserializeObject(String);
			int objectId = (Integer)deserializeObject(Int32);
			boolean isConstructor = (Boolean)deserializeObject(Boolean);
			byte returnType = (Byte)deserializeObject(Byte);
			Class realReturnType = getTypeFromRuntimeType(returnType);
			String methodName = (String)deserializeObject(String);
			int numParameters = (Integer)deserializeObject(Int32);
			
			// figure out what we are invoking on
			Class type;
			Object target;
			if (fullyQualifiedName == null)
			{
				target = myMonoReferences.get(objectId);
				type = target.getClass();
			}
			else
			{
				target = null;
				type = Class.forName(fullyQualifiedName);
			}
			
	        if (type == null && target == null)
	            throw new InvalidClassException("Unable to determine the target of the method invocation.");
	        
	
	        // deserialize the parameters
	        Object[] parameters = new Object[numParameters];
	        Class[] realTypes = new Class[numParameters];
	        boolean clueless = false;
	        // grab all the parameter types from the values or explicitly given types in the null case
	        for (int i = 0; i < numParameters; i++)
	        {
	            byte runtimeType = (Byte)deserializeObject(Byte);
	            Object parameter = parameters[i] = deserializeObject(runtimeType);
	            if (parameter == null)
	            {
	                // if we have a null parameter, try to get it from the explicit parameter list
	                if (runtimeType != Default && runtimeType != JavaObject)
	                {
	                    realTypes[i] = getTypeFromRuntimeType(runtimeType);
	                }
	                else
	                {
	                    // we have no idea what this is... 
	                    // the parameter is null, and no explicit type was given
	                    realTypes[i] = null;
	                    clueless = true;
	                }
	            }
	            else
	            {
	            	// on non value types, we are always searching for ambiguous match because of inheritance.
	            	if (runtimeType == JavaObject || runtimeType == String)
	            		clueless = true;
	                realTypes[i] = parameter.getClass();
	            }
	        }

	        if (numParameters > 0)
            {
                String signatureArgs = realTypes[0].getName();
                for (int i = 1; i < numParameters; i++)
                {
                    signatureArgs += ", " +realTypes[i].getName();
                }
                DebugLog("Desired method signature in %s:\n%s %s(%s)", type.getName(), realReturnType.getName(), methodName, signatureArgs);
            }
	        
            boolean needsConfirmation = true;
            Method method;
            if (!clueless)
            {
                DebugLog("Searching for explicit method signature");                
                method = type.getMethod(methodName, realTypes);
            }
            else
            {
                DebugLog("Searching for ambiguous method signature");
                // ambiguous, so find the one that sort of matches
                method = null;
                Method[] methods = type.getMethods();
                for(Method methodCandidate: methods)
                {
                    if (matchesSignature(methodName, realTypes, realReturnType, methodCandidate))
                    {
                        // preexisting match means it is ambiguous... ie
                        // intent.putExtra(string) and intent.putExtra(parcelable) and null passed in...
                        if (method != null)
                            throw new InvalidParameterException("Ambiguous method match.");
                        method = methodCandidate;
                        needsConfirmation = false;
                    }
                }
            }
            if (method == null)
                throw new InvalidParameterException("Unable to find matching method call.");
            if (needsConfirmation)
            {
                if (!matchesSignature(methodName, realTypes, realReturnType, method))
                    throw new InvalidParameterException("Unable to find matching method call.");
            }
            
            Object ret = method.invoke(target, parameters);
			ByteBufferOutputStream outStream =myWriter.get(); 
			outStream.rewind();
			outStream.writeBoolean(true);
			if (returnType == Void)
			{
				setReturnBuffer(outStream.toByteArray(), outStream.size());
				return;
			}
			
			serializeObject(ret, returnType);
			setReturnBuffer(outStream.toByteArray(), outStream.size());
		}
		catch(Exception e)
		{
			DebugLog("Caught unhandled exception.");
			ByteBufferOutputStream outStream =myWriter.get(); 
			outStream.rewind();
			outStream.writeBoolean(false);
			String message = e.getMessage();
			if (message == null)
				message = "No Message";
			outStream.writeString(message);
			
            DebugLog("Exiting handleInvoke");
			setReturnBuffer(outStream.toByteArray(), outStream.size());
		}
	}
	
	public static String echo(String str)
	{
		DebugLog(str);
		return str;
	}
	
    static Class getTypeFromRuntimeType(byte runtimeType)
    {
    	return myUnconversions.get(runtimeType);
    }

    static byte getRuntimeTypeFromType(Class type)
    {
    	if (!myConversions.containsKey(type))
    		return JavaObject;
    	return myConversions.get(type);
    }

    static byte getRuntimeType(Object arg)
    {
        if (arg == null)
            return Default;
        Class type = arg.getClass();
        return getRuntimeTypeFromType(type);
    }
    
    public static void invoke(String assemblyQualifiedName, String methodName, Object... args) throws Exception
    {
    	invoke(assemblyQualifiedName, 0, false, void.class, methodName, args, null);
    }
    
    public static void invoke(String assemblyQualifiedName, String methodName, Object[] args, byte[] runtimeTypes) throws Exception
    {
    	invoke(assemblyQualifiedName, 0, false, void.class, methodName, args, runtimeTypes);
    }
    
    public static Object invoke(String assemblyQualifiedName, Class returnType, String methodName, Object... args) throws Exception
    {
    	return invoke(assemblyQualifiedName, 0, false, returnType, methodName, args, null);
    }
    
    public static Object invoke(String assemblyQualifiedName, Class returnType, String methodName, Object[] args, byte[] runtimeTypes) throws Exception
    {
    	return invoke(assemblyQualifiedName, 0, false, returnType, methodName, args, runtimeTypes);
    }
    
    static Object invoke(String assemblyQualifiedName, int objectId, boolean isConstructor, Class returnType, String methodName, Object[] args, byte[] runtimeTypes) throws Exception
    {
    	if (runtimeTypes == null)
    		runtimeTypes = new byte[args.length];
    	for(int i = 0; i < runtimeTypes.length; i++)
    	{
    		if (args[i] != null && runtimeTypes[i] == Default)
    			runtimeTypes[i] = getRuntimeType(args[i]);
    	}
    	
    	byte runtimeReturnType = getRuntimeTypeFromType(returnType);
    	ByteBufferOutputStream b = myWriter.get();
    	b.rewind();
    	try
		{
    		serializeObject(assemblyQualifiedName, String);
    		serialize(objectId);
    		serialize(isConstructor);
    		serialize(runtimeReturnType);
    		serializeObject(methodName, String);
    		serialize(args.length);
			serializeParameters(args, runtimeTypes);
		}
		catch (IOException e)
		{
		}
		
    	byte[] bytes = b.toByteArray(); 
    	byte[] retBuf = invokeInternal(bytes, b.size());
    	
    	if (retBuf != bytes)
    		b.setByteArray(retBuf);
    	
		ByteBuffer buffer = b.getByteBuffer();
    	myReader.set(buffer);
		buffer.rewind();
		// eat the buffer size
		int returnBufferSize = buffer.getInt();
		boolean success = (Boolean)deserializeObject(Boolean);
		if (!success)
		{
			String remoteString = deserializeString();
			if (remoteString == null)
				throw new Exception();
			throw new Exception(remoteString);
		}
		if (returnType == void.class)
			return null;

    	return deserializeObject(runtimeReturnType);
    }
 
    static Object deserializeObject(byte runtimeType)
    {
        if (runtimeType == Default)
            return null;
        return myUnconvertHandlers[(byte)runtimeType].Convert();
    }

    static void serialize(Object o) throws IOException
    {
    	if (o == null)
    		throw new InvalidParameterException("argument can not be null.");
    	byte type = getRuntimeType(o);
    	serializeObject(o, type);
    }
    
    static void serializeNull() throws IOException
    {
    	myConvertHandlers[Int32].Convert(-1);
    }
    
    static void serializeObject(Object o, byte objectType) throws IOException
    {
    	if (o == null)
    		serializeNull();
    	else
    		myConvertHandlers[(byte)objectType].Convert(o);
    }

    static void serializeParameters(Object[] parameters, byte[] parameterTypes) throws IOException
    {
    	ByteBufferOutputStream b = myWriter.get();
        for (int i = 0; i < parameters.length; i++)
        {
        	Object parameter = parameters[i];
        	byte actualRuntimeType = getRuntimeType(parameter);
        	if (actualRuntimeType == Void)
        		throw new InvalidParameterException("Can't have a void parameter.");
        	if (actualRuntimeType != parameterTypes[i] && actualRuntimeType != Default)
        	{
        		int maxType = Math.max(actualRuntimeType, parameterTypes[i]);
        		int minType = Math.min(actualRuntimeType, parameterTypes[i]);
        		if (maxType > UInt64 || minType != maxType -1)
        			throw new InvalidParameterException("Can't convert the argument to the specified runtime type");
        	}
        	b.write(parameterTypes[i]);
            serializeObject(parameters[i], parameterTypes[i]);
        }
    }
	
    static native void initializeRuntime();
	static native byte[] invokeInternal(byte[] parameterAndReturnBuffer, int bufferLength);
	public static ByteBuffer ensureBufferLength(int length)
	{
		ByteBuffer buffer = myReader.get();
		if (buffer == null || buffer.capacity() < length)
		{
			buffer = ByteBuffer.allocate(length);
			buffer.order(ByteOrder.nativeOrder());
			myReader.set(buffer);
		}
		return buffer;
	}

	static int myMonoReferenceCounter = 1;
	static Hashtable<Integer, Object> myMonoReferences = new Hashtable<Integer, Object>();

	public static String createAssemblyQualifiedName(String assemblyName, String fullyQualifiedName)
	{
		return java.lang.String.format("%s, %s", fullyQualifiedName, assemblyName);
	}
	
	public static void Initialize()
	{
		
	}
	
	static void removeJavaReference(long objectId)
	{
		myMonoReferences.remove(objectId);
	}
	
	public static MonoObject newMonoObject(String assemblyQualifiedName, Object... args) throws Exception
	{
		return (MonoObject)invoke(assemblyQualifiedName, 0, true, MonoObject.class, null, args, null);
	}
}
