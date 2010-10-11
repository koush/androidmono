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
		internal static global::MonoJavaBridge.MethodId _get14000;
		public abstract byte get();
		internal static global::MonoJavaBridge.MethodId _get14001;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get14001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get14001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get14002;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get14002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get14002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get14003;
		public abstract byte get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put14004;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put14004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put14004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14005;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put14005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put14005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14006;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		internal static global::MonoJavaBridge.MethodId _put14007;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		internal static global::MonoJavaBridge.MethodId _put14008;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put14008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put14008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals14009;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._equals14009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._equals14009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14010;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._toString14010)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._toString14010)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14011;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._hashCode14011);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hashCode14011);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14012;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo14012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo14012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14013;
		public virtual int compareTo(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo14013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo14013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort14014;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getShort14015;
		public abstract short getShort();
		internal static global::MonoJavaBridge.MethodId _putShort14016;
		public abstract global::java.nio.ByteBuffer putShort(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _putShort14017;
		public abstract global::java.nio.ByteBuffer putShort(short arg0);
		internal static global::MonoJavaBridge.MethodId _getChar14018;
		public abstract char getChar();
		internal static global::MonoJavaBridge.MethodId _getChar14019;
		public abstract char getChar(int arg0);
		internal static global::MonoJavaBridge.MethodId _putChar14020;
		public abstract global::java.nio.ByteBuffer putChar(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _putChar14021;
		public abstract global::java.nio.ByteBuffer putChar(char arg0);
		internal static global::MonoJavaBridge.MethodId _getInt14022;
		public abstract int getInt();
		internal static global::MonoJavaBridge.MethodId _getInt14023;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _putInt14024;
		public abstract global::java.nio.ByteBuffer putInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt14025;
		public abstract global::java.nio.ByteBuffer putInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong14026;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong14027;
		public abstract long getLong();
		internal static global::MonoJavaBridge.MethodId _putLong14028;
		public abstract global::java.nio.ByteBuffer putLong(long arg0);
		internal static global::MonoJavaBridge.MethodId _putLong14029;
		public abstract global::java.nio.ByteBuffer putLong(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat14030;
		public abstract float getFloat();
		internal static global::MonoJavaBridge.MethodId _getFloat14031;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat14032;
		public abstract global::java.nio.ByteBuffer putFloat(float arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat14033;
		public abstract global::java.nio.ByteBuffer putFloat(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble14034;
		public abstract double getDouble();
		internal static global::MonoJavaBridge.MethodId _getDouble14035;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _putDouble14036;
		public abstract global::java.nio.ByteBuffer putDouble(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble14037;
		public abstract global::java.nio.ByteBuffer putDouble(double arg0);
		internal static global::MonoJavaBridge.MethodId _isDirect14038;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray14039;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._hasArray14039);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hasArray14039);
		}
		internal static global::MonoJavaBridge.MethodId _array14040;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._array14040)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._array14040)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset14041;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._arrayOffset14041);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._arrayOffset14041);
		}
		internal static global::MonoJavaBridge.MethodId _wrap14042;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap14042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap14043;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap14043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate14044;
		public static global::java.nio.ByteBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate14044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate14045;
		public abstract global::java.nio.ByteBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _allocateDirect14046;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect14046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice14047;
		public abstract global::java.nio.ByteBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer14048;
		public abstract global::java.nio.ByteBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact14049;
		public abstract global::java.nio.ByteBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order14050;
		public virtual global::java.nio.ByteBuffer order(java.nio.ByteOrder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order14050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order14050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order14051;
		public virtual global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order14051)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order14051)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer14052;
		public abstract global::java.nio.CharBuffer asCharBuffer();
		internal static global::MonoJavaBridge.MethodId _asShortBuffer14053;
		public abstract global::java.nio.ShortBuffer asShortBuffer();
		internal static global::MonoJavaBridge.MethodId _asIntBuffer14054;
		public abstract global::java.nio.IntBuffer asIntBuffer();
		internal static global::MonoJavaBridge.MethodId _asLongBuffer14055;
		public abstract global::java.nio.LongBuffer asLongBuffer();
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer14056;
		public abstract global::java.nio.FloatBuffer asFloatBuffer();
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer14057;
		public abstract global::java.nio.DoubleBuffer asDoubleBuffer();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer._get14000 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "()B");
			global::java.nio.ByteBuffer._get14001 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get14002 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get14003 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer._put14004 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put14005 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put14006 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put14007 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put14008 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._equals14009 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ByteBuffer._toString14010 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteBuffer._hashCode14011 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ByteBuffer._compareTo14012 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ByteBuffer._compareTo14013 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.ByteBuffer._getShort14014 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer._getShort14015 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer._putShort14016 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putShort14017 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getChar14018 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer._getChar14019 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer._putChar14020 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putChar14021 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getInt14022 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer._getInt14023 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer._putInt14024 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putInt14025 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getLong14026 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer._getLong14027 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer._putLong14028 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putLong14029 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getFloat14030 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer._getFloat14031 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer._putFloat14032 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putFloat14033 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getDouble14034 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer._getDouble14035 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer._putDouble14036 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putDouble14037 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._isDirect14038 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer._hasArray14039 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ByteBuffer._array14040 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ByteBuffer._arrayOffset14041 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ByteBuffer._wrap14042 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._wrap14043 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocate14044 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._duplicate14045 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocateDirect14046 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._slice14047 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._asReadOnlyBuffer14048 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._compact14049 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order14050 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order14051 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ByteBuffer._asCharBuffer14052 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer._asShortBuffer14053 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer._asIntBuffer14054 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer._asLongBuffer14055 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer._asFloatBuffer14056 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer._asDoubleBuffer14057 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
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
		internal static global::MonoJavaBridge.MethodId _get14058;
		public override byte get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get14058);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get14058);
		}
		internal static global::MonoJavaBridge.MethodId _get14059;
		public override byte get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get14059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get14059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put14060;
		public override global::java.nio.ByteBuffer put(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put14060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put14060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14061;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put14061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put14061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort14062;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort14062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort14062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort14063;
		public override short getShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort14063);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort14063);
		}
		internal static global::MonoJavaBridge.MethodId _putShort14064;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort14064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort14064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort14065;
		public override global::java.nio.ByteBuffer putShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort14065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort14065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar14066;
		public override char getChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar14066);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar14066);
		}
		internal static global::MonoJavaBridge.MethodId _getChar14067;
		public override char getChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar14067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar14067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar14068;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar14068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar14068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar14069;
		public override global::java.nio.ByteBuffer putChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar14069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar14069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt14070;
		public override int getInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt14070);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt14070);
		}
		internal static global::MonoJavaBridge.MethodId _getInt14071;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt14071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt14071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt14072;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt14072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt14072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt14073;
		public override global::java.nio.ByteBuffer putInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt14073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt14073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong14074;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong14074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong14074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong14075;
		public override long getLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong14075);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong14075);
		}
		internal static global::MonoJavaBridge.MethodId _putLong14076;
		public override global::java.nio.ByteBuffer putLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong14076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong14076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong14077;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong14077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong14077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat14078;
		public override float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat14078);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat14078);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat14079;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat14079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat14079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat14080;
		public override global::java.nio.ByteBuffer putFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat14080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat14080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat14081;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat14081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat14081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble14082;
		public override double getDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble14082);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble14082);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble14083;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble14083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble14083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble14084;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble14084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble14084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble14085;
		public override global::java.nio.ByteBuffer putDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble14085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble14085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect14086;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isDirect14086);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isDirect14086);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate14087;
		public override global::java.nio.ByteBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._duplicate14087)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._duplicate14087)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice14088;
		public override global::java.nio.ByteBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._slice14088)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._slice14088)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer14089;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asReadOnlyBuffer14089)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asReadOnlyBuffer14089)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact14090;
		public override global::java.nio.ByteBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._compact14090)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._compact14090)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer14091;
		public override global::java.nio.CharBuffer asCharBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asCharBuffer14091)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asCharBuffer14091)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer14092;
		public override global::java.nio.ShortBuffer asShortBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asShortBuffer14092)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asShortBuffer14092)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer14093;
		public override global::java.nio.IntBuffer asIntBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asIntBuffer14093)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asIntBuffer14093)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer14094;
		public override global::java.nio.LongBuffer asLongBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asLongBuffer14094)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asLongBuffer14094)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer14095;
		public override global::java.nio.FloatBuffer asFloatBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asFloatBuffer14095)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asFloatBuffer14095)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer14096;
		public override global::java.nio.DoubleBuffer asDoubleBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asDoubleBuffer14096)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asDoubleBuffer14096)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly14097;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isReadOnly14097);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isReadOnly14097);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer_._get14058 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "()B");
			global::java.nio.ByteBuffer_._get14059 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer_._put14060 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._put14061 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getShort14062 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer_._getShort14063 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer_._putShort14064 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putShort14065 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getChar14066 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer_._getChar14067 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer_._putChar14068 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putChar14069 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getInt14070 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer_._getInt14071 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer_._putInt14072 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putInt14073 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getLong14074 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer_._getLong14075 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer_._putLong14076 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putLong14077 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getFloat14078 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer_._getFloat14079 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer_._putFloat14080 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putFloat14081 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getDouble14082 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer_._getDouble14083 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer_._putDouble14084 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putDouble14085 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._isDirect14086 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer_._duplicate14087 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._slice14088 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asReadOnlyBuffer14089 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._compact14090 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asCharBuffer14091 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer_._asShortBuffer14092 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer_._asIntBuffer14093 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer_._asLongBuffer14094 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer_._asFloatBuffer14095 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer_._asDoubleBuffer14096 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.ByteBuffer_._isReadOnly14097 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
