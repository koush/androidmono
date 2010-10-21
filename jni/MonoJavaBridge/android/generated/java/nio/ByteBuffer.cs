namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ByteBuffer_))]
	public abstract partial class ByteBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteBuffer()
		{
			InitJNI();
		}
		protected ByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21898;
		public abstract byte get();
		internal static global::MonoJavaBridge.MethodId _get21899;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get21899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get21899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get21900;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get21900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get21900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get21901;
		public abstract byte get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put21902;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put21902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put21902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put21903;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put21903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put21903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put21904;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		internal static global::MonoJavaBridge.MethodId _put21905;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		internal static global::MonoJavaBridge.MethodId _put21906;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put21906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put21906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals21907;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._equals21907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._equals21907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21908;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._toString21908)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._toString21908)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21909;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._hashCode21909);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hashCode21909);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21910;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo21910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo21910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21911;
		public virtual int compareTo(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo21911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo21911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort21912;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getShort21913;
		public abstract short getShort();
		internal static global::MonoJavaBridge.MethodId _putShort21914;
		public abstract global::java.nio.ByteBuffer putShort(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _putShort21915;
		public abstract global::java.nio.ByteBuffer putShort(short arg0);
		internal static global::MonoJavaBridge.MethodId _getChar21916;
		public abstract char getChar();
		internal static global::MonoJavaBridge.MethodId _getChar21917;
		public abstract char getChar(int arg0);
		internal static global::MonoJavaBridge.MethodId _putChar21918;
		public abstract global::java.nio.ByteBuffer putChar(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _putChar21919;
		public abstract global::java.nio.ByteBuffer putChar(char arg0);
		internal static global::MonoJavaBridge.MethodId _getInt21920;
		public abstract int getInt();
		internal static global::MonoJavaBridge.MethodId _getInt21921;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _putInt21922;
		public abstract global::java.nio.ByteBuffer putInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt21923;
		public abstract global::java.nio.ByteBuffer putInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong21924;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong21925;
		public abstract long getLong();
		internal static global::MonoJavaBridge.MethodId _putLong21926;
		public abstract global::java.nio.ByteBuffer putLong(long arg0);
		internal static global::MonoJavaBridge.MethodId _putLong21927;
		public abstract global::java.nio.ByteBuffer putLong(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat21928;
		public abstract float getFloat();
		internal static global::MonoJavaBridge.MethodId _getFloat21929;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat21930;
		public abstract global::java.nio.ByteBuffer putFloat(float arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat21931;
		public abstract global::java.nio.ByteBuffer putFloat(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble21932;
		public abstract double getDouble();
		internal static global::MonoJavaBridge.MethodId _getDouble21933;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _putDouble21934;
		public abstract global::java.nio.ByteBuffer putDouble(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble21935;
		public abstract global::java.nio.ByteBuffer putDouble(double arg0);
		internal static global::MonoJavaBridge.MethodId _isDirect21936;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray21937;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._hasArray21937);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hasArray21937);
		}
		internal static global::MonoJavaBridge.MethodId _array21938;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._array21938)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._array21938)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset21939;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._arrayOffset21939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._arrayOffset21939);
		}
		internal static global::MonoJavaBridge.MethodId _wrap21940;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap21940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap21941;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap21941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate21942;
		public static global::java.nio.ByteBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate21942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate21943;
		public abstract global::java.nio.ByteBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _allocateDirect21944;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect21944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice21945;
		public abstract global::java.nio.ByteBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer21946;
		public abstract global::java.nio.ByteBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact21947;
		public abstract global::java.nio.ByteBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order21948;
		public virtual global::java.nio.ByteBuffer order(java.nio.ByteOrder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order21948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order21948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order21949;
		public virtual global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order21949)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order21949)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer21950;
		public abstract global::java.nio.CharBuffer asCharBuffer();
		internal static global::MonoJavaBridge.MethodId _asShortBuffer21951;
		public abstract global::java.nio.ShortBuffer asShortBuffer();
		internal static global::MonoJavaBridge.MethodId _asIntBuffer21952;
		public abstract global::java.nio.IntBuffer asIntBuffer();
		internal static global::MonoJavaBridge.MethodId _asLongBuffer21953;
		public abstract global::java.nio.LongBuffer asLongBuffer();
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer21954;
		public abstract global::java.nio.FloatBuffer asFloatBuffer();
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer21955;
		public abstract global::java.nio.DoubleBuffer asDoubleBuffer();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer._get21898 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "()B");
			global::java.nio.ByteBuffer._get21899 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get21900 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get21901 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer._put21902 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put21903 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put21904 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put21905 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put21906 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._equals21907 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ByteBuffer._toString21908 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteBuffer._hashCode21909 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ByteBuffer._compareTo21910 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ByteBuffer._compareTo21911 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.ByteBuffer._getShort21912 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer._getShort21913 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer._putShort21914 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putShort21915 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getChar21916 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer._getChar21917 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer._putChar21918 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putChar21919 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getInt21920 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer._getInt21921 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer._putInt21922 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putInt21923 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getLong21924 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer._getLong21925 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer._putLong21926 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putLong21927 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getFloat21928 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer._getFloat21929 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer._putFloat21930 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putFloat21931 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getDouble21932 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer._getDouble21933 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer._putDouble21934 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putDouble21935 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._isDirect21936 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer._hasArray21937 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ByteBuffer._array21938 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ByteBuffer._arrayOffset21939 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ByteBuffer._wrap21940 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._wrap21941 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocate21942 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._duplicate21943 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocateDirect21944 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._slice21945 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._asReadOnlyBuffer21946 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._compact21947 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order21948 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order21949 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ByteBuffer._asCharBuffer21950 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer._asShortBuffer21951 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer._asIntBuffer21952 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer._asLongBuffer21953 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer._asFloatBuffer21954 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer._asDoubleBuffer21955 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ByteBuffer))]
	public sealed partial class ByteBuffer_ : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteBuffer_()
		{
			InitJNI();
		}
		internal ByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21956;
		public override byte get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get21956);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get21956);
		}
		internal static global::MonoJavaBridge.MethodId _get21957;
		public override byte get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get21957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get21957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put21958;
		public override global::java.nio.ByteBuffer put(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put21958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put21958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put21959;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put21959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put21959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort21960;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort21960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort21960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort21961;
		public override short getShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort21961);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort21961);
		}
		internal static global::MonoJavaBridge.MethodId _putShort21962;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort21962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort21962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort21963;
		public override global::java.nio.ByteBuffer putShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort21963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort21963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar21964;
		public override char getChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar21964);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar21964);
		}
		internal static global::MonoJavaBridge.MethodId _getChar21965;
		public override char getChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar21965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar21965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar21966;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar21966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar21966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar21967;
		public override global::java.nio.ByteBuffer putChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar21967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar21967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt21968;
		public override int getInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt21968);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt21968);
		}
		internal static global::MonoJavaBridge.MethodId _getInt21969;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt21969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt21969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt21970;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt21970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt21970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt21971;
		public override global::java.nio.ByteBuffer putInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt21971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt21971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong21972;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong21972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong21972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong21973;
		public override long getLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong21973);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong21973);
		}
		internal static global::MonoJavaBridge.MethodId _putLong21974;
		public override global::java.nio.ByteBuffer putLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong21974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong21974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong21975;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong21975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong21975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat21976;
		public override float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat21976);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat21976);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat21977;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat21977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat21977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat21978;
		public override global::java.nio.ByteBuffer putFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat21978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat21978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat21979;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat21979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat21979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble21980;
		public override double getDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble21980);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble21980);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble21981;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble21981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble21981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble21982;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble21982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble21982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble21983;
		public override global::java.nio.ByteBuffer putDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble21983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble21983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect21984;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isDirect21984);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isDirect21984);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate21985;
		public override global::java.nio.ByteBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._duplicate21985)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._duplicate21985)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice21986;
		public override global::java.nio.ByteBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._slice21986)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._slice21986)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer21987;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asReadOnlyBuffer21987)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asReadOnlyBuffer21987)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact21988;
		public override global::java.nio.ByteBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._compact21988)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._compact21988)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer21989;
		public override global::java.nio.CharBuffer asCharBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asCharBuffer21989)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asCharBuffer21989)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer21990;
		public override global::java.nio.ShortBuffer asShortBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asShortBuffer21990)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asShortBuffer21990)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer21991;
		public override global::java.nio.IntBuffer asIntBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asIntBuffer21991)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asIntBuffer21991)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer21992;
		public override global::java.nio.LongBuffer asLongBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asLongBuffer21992)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asLongBuffer21992)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer21993;
		public override global::java.nio.FloatBuffer asFloatBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asFloatBuffer21993)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asFloatBuffer21993)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer21994;
		public override global::java.nio.DoubleBuffer asDoubleBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asDoubleBuffer21994)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asDoubleBuffer21994)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly21995;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isReadOnly21995);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isReadOnly21995);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer_._get21956 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "()B");
			global::java.nio.ByteBuffer_._get21957 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer_._put21958 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._put21959 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getShort21960 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer_._getShort21961 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer_._putShort21962 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putShort21963 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getChar21964 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer_._getChar21965 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer_._putChar21966 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putChar21967 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getInt21968 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer_._getInt21969 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer_._putInt21970 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putInt21971 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getLong21972 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer_._getLong21973 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer_._putLong21974 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putLong21975 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getFloat21976 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer_._getFloat21977 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer_._putFloat21978 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putFloat21979 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getDouble21980 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer_._getDouble21981 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer_._putDouble21982 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putDouble21983 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._isDirect21984 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer_._duplicate21985 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._slice21986 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asReadOnlyBuffer21987 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._compact21988 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asCharBuffer21989 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer_._asShortBuffer21990 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer_._asIntBuffer21991 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer_._asLongBuffer21992 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer_._asFloatBuffer21993 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer_._asDoubleBuffer21994 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.ByteBuffer_._isReadOnly21995 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
