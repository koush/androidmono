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
		internal static global::MonoJavaBridge.MethodId _get16304;
		public abstract byte get();
		internal static global::MonoJavaBridge.MethodId _get16305;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get16305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get16305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16306;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get16306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get16306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16307;
		public abstract byte get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16308;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put16308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put16308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16309;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put16309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put16309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16310;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		internal static global::MonoJavaBridge.MethodId _put16311;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		internal static global::MonoJavaBridge.MethodId _put16312;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put16312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put16312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16313;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._equals16313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._equals16313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16314;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._toString16314)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._toString16314)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16315;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._hashCode16315);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hashCode16315);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16316;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo16316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo16316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16317;
		public virtual int compareTo(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo16317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo16317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort16318;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getShort16319;
		public abstract short getShort();
		internal static global::MonoJavaBridge.MethodId _putShort16320;
		public abstract global::java.nio.ByteBuffer putShort(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _putShort16321;
		public abstract global::java.nio.ByteBuffer putShort(short arg0);
		internal static global::MonoJavaBridge.MethodId _getChar16322;
		public abstract char getChar();
		internal static global::MonoJavaBridge.MethodId _getChar16323;
		public abstract char getChar(int arg0);
		internal static global::MonoJavaBridge.MethodId _putChar16324;
		public abstract global::java.nio.ByteBuffer putChar(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _putChar16325;
		public abstract global::java.nio.ByteBuffer putChar(char arg0);
		internal static global::MonoJavaBridge.MethodId _getInt16326;
		public abstract int getInt();
		internal static global::MonoJavaBridge.MethodId _getInt16327;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _putInt16328;
		public abstract global::java.nio.ByteBuffer putInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt16329;
		public abstract global::java.nio.ByteBuffer putInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong16330;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong16331;
		public abstract long getLong();
		internal static global::MonoJavaBridge.MethodId _putLong16332;
		public abstract global::java.nio.ByteBuffer putLong(long arg0);
		internal static global::MonoJavaBridge.MethodId _putLong16333;
		public abstract global::java.nio.ByteBuffer putLong(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat16334;
		public abstract float getFloat();
		internal static global::MonoJavaBridge.MethodId _getFloat16335;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat16336;
		public abstract global::java.nio.ByteBuffer putFloat(float arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat16337;
		public abstract global::java.nio.ByteBuffer putFloat(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble16338;
		public abstract double getDouble();
		internal static global::MonoJavaBridge.MethodId _getDouble16339;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _putDouble16340;
		public abstract global::java.nio.ByteBuffer putDouble(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble16341;
		public abstract global::java.nio.ByteBuffer putDouble(double arg0);
		internal static global::MonoJavaBridge.MethodId _isDirect16342;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16343;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._hasArray16343);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hasArray16343);
		}
		internal static global::MonoJavaBridge.MethodId _array16344;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._array16344)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._array16344)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16345;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._arrayOffset16345);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._arrayOffset16345);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16346;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap16346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16347;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap16347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate16348;
		public static global::java.nio.ByteBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate16348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16349;
		public abstract global::java.nio.ByteBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _allocateDirect16350;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect16350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16351;
		public abstract global::java.nio.ByteBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16352;
		public abstract global::java.nio.ByteBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16353;
		public abstract global::java.nio.ByteBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16354;
		public virtual global::java.nio.ByteBuffer order(java.nio.ByteOrder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order16354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order16354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16355;
		public virtual global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order16355)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order16355)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer16356;
		public abstract global::java.nio.CharBuffer asCharBuffer();
		internal static global::MonoJavaBridge.MethodId _asShortBuffer16357;
		public abstract global::java.nio.ShortBuffer asShortBuffer();
		internal static global::MonoJavaBridge.MethodId _asIntBuffer16358;
		public abstract global::java.nio.IntBuffer asIntBuffer();
		internal static global::MonoJavaBridge.MethodId _asLongBuffer16359;
		public abstract global::java.nio.LongBuffer asLongBuffer();
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer16360;
		public abstract global::java.nio.FloatBuffer asFloatBuffer();
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer16361;
		public abstract global::java.nio.DoubleBuffer asDoubleBuffer();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer._get16304 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "()B");
			global::java.nio.ByteBuffer._get16305 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get16306 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get16307 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer._put16308 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put16309 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put16310 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put16311 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put16312 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._equals16313 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ByteBuffer._toString16314 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteBuffer._hashCode16315 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ByteBuffer._compareTo16316 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ByteBuffer._compareTo16317 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.ByteBuffer._getShort16318 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer._getShort16319 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer._putShort16320 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putShort16321 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getChar16322 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer._getChar16323 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer._putChar16324 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putChar16325 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getInt16326 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer._getInt16327 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer._putInt16328 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putInt16329 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getLong16330 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer._getLong16331 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer._putLong16332 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putLong16333 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getFloat16334 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer._getFloat16335 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer._putFloat16336 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putFloat16337 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getDouble16338 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer._getDouble16339 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer._putDouble16340 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putDouble16341 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._isDirect16342 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer._hasArray16343 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ByteBuffer._array16344 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ByteBuffer._arrayOffset16345 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ByteBuffer._wrap16346 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._wrap16347 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocate16348 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._duplicate16349 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocateDirect16350 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._slice16351 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._asReadOnlyBuffer16352 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._compact16353 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order16354 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order16355 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ByteBuffer._asCharBuffer16356 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer._asShortBuffer16357 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer._asIntBuffer16358 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer._asLongBuffer16359 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer._asFloatBuffer16360 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer._asDoubleBuffer16361 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
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
		internal static global::MonoJavaBridge.MethodId _get16362;
		public override byte get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get16362);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get16362);
		}
		internal static global::MonoJavaBridge.MethodId _get16363;
		public override byte get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get16363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get16363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16364;
		public override global::java.nio.ByteBuffer put(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put16364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put16364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16365;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put16365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put16365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort16366;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort16366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort16366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort16367;
		public override short getShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort16367);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort16367);
		}
		internal static global::MonoJavaBridge.MethodId _putShort16368;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort16368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort16368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort16369;
		public override global::java.nio.ByteBuffer putShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort16369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort16369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar16370;
		public override char getChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar16370);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar16370);
		}
		internal static global::MonoJavaBridge.MethodId _getChar16371;
		public override char getChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar16371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar16371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar16372;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar16372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar16372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar16373;
		public override global::java.nio.ByteBuffer putChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar16373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar16373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt16374;
		public override int getInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt16374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt16374);
		}
		internal static global::MonoJavaBridge.MethodId _getInt16375;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt16375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt16375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt16376;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt16376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt16376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt16377;
		public override global::java.nio.ByteBuffer putInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt16377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt16377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong16378;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong16378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong16378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong16379;
		public override long getLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong16379);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong16379);
		}
		internal static global::MonoJavaBridge.MethodId _putLong16380;
		public override global::java.nio.ByteBuffer putLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong16380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong16380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong16381;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong16381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong16381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat16382;
		public override float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat16382);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat16382);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat16383;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat16383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat16383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat16384;
		public override global::java.nio.ByteBuffer putFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat16384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat16384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat16385;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat16385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat16385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble16386;
		public override double getDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble16386);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble16386);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble16387;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble16387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble16387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble16388;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble16388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble16388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble16389;
		public override global::java.nio.ByteBuffer putDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble16389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble16389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16390;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isDirect16390);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isDirect16390);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16391;
		public override global::java.nio.ByteBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._duplicate16391)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._duplicate16391)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16392;
		public override global::java.nio.ByteBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._slice16392)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._slice16392)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16393;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asReadOnlyBuffer16393)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asReadOnlyBuffer16393)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16394;
		public override global::java.nio.ByteBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._compact16394)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._compact16394)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer16395;
		public override global::java.nio.CharBuffer asCharBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asCharBuffer16395)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asCharBuffer16395)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer16396;
		public override global::java.nio.ShortBuffer asShortBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asShortBuffer16396)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asShortBuffer16396)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer16397;
		public override global::java.nio.IntBuffer asIntBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asIntBuffer16397)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asIntBuffer16397)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer16398;
		public override global::java.nio.LongBuffer asLongBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asLongBuffer16398)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asLongBuffer16398)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer16399;
		public override global::java.nio.FloatBuffer asFloatBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asFloatBuffer16399)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asFloatBuffer16399)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer16400;
		public override global::java.nio.DoubleBuffer asDoubleBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asDoubleBuffer16400)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asDoubleBuffer16400)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16401;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isReadOnly16401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isReadOnly16401);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer_._get16362 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "()B");
			global::java.nio.ByteBuffer_._get16363 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer_._put16364 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._put16365 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getShort16366 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer_._getShort16367 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer_._putShort16368 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putShort16369 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getChar16370 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer_._getChar16371 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer_._putChar16372 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putChar16373 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getInt16374 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer_._getInt16375 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer_._putInt16376 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putInt16377 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getLong16378 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer_._getLong16379 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer_._putLong16380 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putLong16381 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getFloat16382 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer_._getFloat16383 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer_._putFloat16384 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putFloat16385 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getDouble16386 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer_._getDouble16387 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer_._putDouble16388 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putDouble16389 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._isDirect16390 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer_._duplicate16391 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._slice16392 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asReadOnlyBuffer16393 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._compact16394 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asCharBuffer16395 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer_._asShortBuffer16396 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer_._asIntBuffer16397 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer_._asLongBuffer16398 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer_._asFloatBuffer16399 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer_._asDoubleBuffer16400 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.ByteBuffer_._isReadOnly16401 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
