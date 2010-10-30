namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ByteBuffer_))]
	public abstract partial class ByteBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22017;
		public abstract byte get();
		internal static global::MonoJavaBridge.MethodId _get22018;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._get22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22019;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._get22019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22020;
		public abstract byte get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22021;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._put22021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22022;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._put22022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22023;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		internal static global::MonoJavaBridge.MethodId _put22024;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		internal static global::MonoJavaBridge.MethodId _put22025;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._put22025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22026;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.ByteBuffer._equals22026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22027;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.ByteBuffer._toString22027) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22028;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "hashCode", "()I", ref global::java.nio.ByteBuffer._hashCode22028);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22029;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.ByteBuffer._compareTo22029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22030;
		public virtual int compareTo(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.ByteBuffer._compareTo22030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22031;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getShort22032;
		public abstract short getShort();
		internal static global::MonoJavaBridge.MethodId _putShort22033;
		public abstract global::java.nio.ByteBuffer putShort(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _putShort22034;
		public abstract global::java.nio.ByteBuffer putShort(short arg0);
		internal static global::MonoJavaBridge.MethodId _getChar22035;
		public abstract char getChar();
		internal static global::MonoJavaBridge.MethodId _getChar22036;
		public abstract char getChar(int arg0);
		internal static global::MonoJavaBridge.MethodId _putChar22037;
		public abstract global::java.nio.ByteBuffer putChar(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _putChar22038;
		public abstract global::java.nio.ByteBuffer putChar(char arg0);
		internal static global::MonoJavaBridge.MethodId _getInt22039;
		public abstract int getInt();
		internal static global::MonoJavaBridge.MethodId _getInt22040;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _putInt22041;
		public abstract global::java.nio.ByteBuffer putInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt22042;
		public abstract global::java.nio.ByteBuffer putInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong22043;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong22044;
		public abstract long getLong();
		internal static global::MonoJavaBridge.MethodId _putLong22045;
		public abstract global::java.nio.ByteBuffer putLong(long arg0);
		internal static global::MonoJavaBridge.MethodId _putLong22046;
		public abstract global::java.nio.ByteBuffer putLong(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat22047;
		public abstract float getFloat();
		internal static global::MonoJavaBridge.MethodId _getFloat22048;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat22049;
		public abstract global::java.nio.ByteBuffer putFloat(float arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat22050;
		public abstract global::java.nio.ByteBuffer putFloat(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble22051;
		public abstract double getDouble();
		internal static global::MonoJavaBridge.MethodId _getDouble22052;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _putDouble22053;
		public abstract global::java.nio.ByteBuffer putDouble(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble22054;
		public abstract global::java.nio.ByteBuffer putDouble(double arg0);
		internal static global::MonoJavaBridge.MethodId _isDirect22055;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22056;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.ByteBuffer._hasArray22056);
		}
		internal static global::MonoJavaBridge.MethodId _array22057;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.ByteBuffer._array22057) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22058;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.ByteBuffer._arrayOffset22058);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22059;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._wrap22059.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._wrap22059 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap22059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22060;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._wrap22060.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._wrap22060 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap22060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22061;
		public static global::java.nio.ByteBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._allocate22061.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._allocate22061 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate22061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22062;
		public abstract global::java.nio.ByteBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _allocateDirect22063;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._allocateDirect22063.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._allocateDirect22063 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect22063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22064;
		public abstract global::java.nio.ByteBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22065;
		public abstract global::java.nio.ByteBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22066;
		public abstract global::java.nio.ByteBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22067;
		public virtual global::java.nio.ByteBuffer order(java.nio.ByteOrder arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._order22067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22068;
		public virtual global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.ByteBuffer._order22068) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22069;
		public abstract global::java.nio.CharBuffer asCharBuffer();
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22070;
		public abstract global::java.nio.ShortBuffer asShortBuffer();
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22071;
		public abstract global::java.nio.IntBuffer asIntBuffer();
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22072;
		public abstract global::java.nio.LongBuffer asLongBuffer();
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22073;
		public abstract global::java.nio.FloatBuffer asFloatBuffer();
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22074;
		public abstract global::java.nio.DoubleBuffer asDoubleBuffer();
		static ByteBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ByteBuffer))]
	internal sealed partial class ByteBuffer_ : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22075;
		public override byte get()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.nio.ByteBuffer_.staticClass, "get", "()B", ref global::java.nio.ByteBuffer_._get22075);
		}
		internal static global::MonoJavaBridge.MethodId _get22076;
		public override byte get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.nio.ByteBuffer_.staticClass, "get", "(I)B", ref global::java.nio.ByteBuffer_._get22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22077;
		public override global::java.nio.ByteBuffer put(byte arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22078;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._put22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort22079;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S", ref global::java.nio.ByteBuffer_._getShort22079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22080;
		public override short getShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ByteBuffer_.staticClass, "getShort", "()S", ref global::java.nio.ByteBuffer_._getShort22080);
		}
		internal static global::MonoJavaBridge.MethodId _putShort22081;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putShort22081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort22082;
		public override global::java.nio.ByteBuffer putShort(short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putShort22082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar22083;
		public override char getChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.ByteBuffer_.staticClass, "getChar", "()C", ref global::java.nio.ByteBuffer_._getChar22083);
		}
		internal static global::MonoJavaBridge.MethodId _getChar22084;
		public override char getChar(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C", ref global::java.nio.ByteBuffer_._getChar22084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar22085;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putChar22085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar22086;
		public override global::java.nio.ByteBuffer putChar(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putChar22086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt22087;
		public override int getInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer_.staticClass, "getInt", "()I", ref global::java.nio.ByteBuffer_._getInt22087);
		}
		internal static global::MonoJavaBridge.MethodId _getInt22088;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I", ref global::java.nio.ByteBuffer_._getInt22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22089;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putInt22089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt22090;
		public override global::java.nio.ByteBuffer putInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putInt22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong22091;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J", ref global::java.nio.ByteBuffer_._getLong22091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22092;
		public override long getLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.ByteBuffer_.staticClass, "getLong", "()J", ref global::java.nio.ByteBuffer_._getLong22092);
		}
		internal static global::MonoJavaBridge.MethodId _putLong22093;
		public override global::java.nio.ByteBuffer putLong(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putLong22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong22094;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putLong22094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22095;
		public override float getFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F", ref global::java.nio.ByteBuffer_._getFloat22095);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22096;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F", ref global::java.nio.ByteBuffer_._getFloat22096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22097;
		public override global::java.nio.ByteBuffer putFloat(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putFloat22097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22098;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putFloat22098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22099;
		public override double getDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D", ref global::java.nio.ByteBuffer_._getDouble22099);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22100;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D", ref global::java.nio.ByteBuffer_._getDouble22100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22101;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putDouble22101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22102;
		public override global::java.nio.ByteBuffer putDouble(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._putDouble22102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22103;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.ByteBuffer_._isDirect22103);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22104;
		public override global::java.nio.ByteBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._duplicate22104) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22105;
		public override global::java.nio.ByteBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._slice22105) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22106;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._asReadOnlyBuffer22106) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22107;
		public override global::java.nio.ByteBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._compact22107) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22108;
		public override global::java.nio.CharBuffer asCharBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;", ref global::java.nio.ByteBuffer_._asCharBuffer22108) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22109;
		public override global::java.nio.ShortBuffer asShortBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ByteBuffer_._asShortBuffer22109) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22110;
		public override global::java.nio.IntBuffer asIntBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;", ref global::java.nio.ByteBuffer_._asIntBuffer22110) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22111;
		public override global::java.nio.LongBuffer asLongBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;", ref global::java.nio.ByteBuffer_._asLongBuffer22111) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22112;
		public override global::java.nio.FloatBuffer asFloatBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;", ref global::java.nio.ByteBuffer_._asFloatBuffer22112) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22113;
		public override global::java.nio.DoubleBuffer asDoubleBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.ByteBuffer_._asDoubleBuffer22113) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22114;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.ByteBuffer_._isReadOnly22114);
		}
		static ByteBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
