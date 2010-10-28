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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22019;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get22019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get22019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22020;
		public abstract byte get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22021;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put22021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put22021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22022;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put22022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put22022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22023;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		internal static global::MonoJavaBridge.MethodId _put22024;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		internal static global::MonoJavaBridge.MethodId _put22025;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put22025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put22025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22026;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._equals22026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._equals22026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22027;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._toString22027)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._toString22027)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22028;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._hashCode22028);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hashCode22028);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22029;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo22029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo22029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22030;
		public virtual int compareTo(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo22030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo22030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._hasArray22056);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hasArray22056);
		}
		internal static global::MonoJavaBridge.MethodId _array22057;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._array22057)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._array22057)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22058;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._arrayOffset22058);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._arrayOffset22058);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22059;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap22059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22060;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap22060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22061;
		public static global::java.nio.ByteBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate22061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22062;
		public abstract global::java.nio.ByteBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _allocateDirect22063;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order22067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order22067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22068;
		public virtual global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order22068)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order22068)) as java.nio.ByteOrder;
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
			global::java.nio.ByteBuffer._get22017 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "()B");
			global::java.nio.ByteBuffer._get22018 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get22019 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get22020 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer._put22021 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22022 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22023 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22024 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22025 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._equals22026 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ByteBuffer._toString22027 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteBuffer._hashCode22028 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ByteBuffer._compareTo22029 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ByteBuffer._compareTo22030 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.ByteBuffer._getShort22031 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer._getShort22032 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer._putShort22033 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putShort22034 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getChar22035 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer._getChar22036 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer._putChar22037 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putChar22038 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getInt22039 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer._getInt22040 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer._putInt22041 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putInt22042 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getLong22043 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer._getLong22044 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer._putLong22045 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putLong22046 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getFloat22047 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer._getFloat22048 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer._putFloat22049 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putFloat22050 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getDouble22051 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer._getDouble22052 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer._putDouble22053 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putDouble22054 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._isDirect22055 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer._hasArray22056 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ByteBuffer._array22057 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ByteBuffer._arrayOffset22058 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ByteBuffer._wrap22059 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._wrap22060 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocate22061 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._duplicate22062 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocateDirect22063 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._slice22064 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._asReadOnlyBuffer22065 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._compact22066 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order22067 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order22068 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ByteBuffer._asCharBuffer22069 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer._asShortBuffer22070 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer._asIntBuffer22071 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer._asLongBuffer22072 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer._asFloatBuffer22073 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer._asDoubleBuffer22074 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get22075);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get22075);
		}
		internal static global::MonoJavaBridge.MethodId _get22076;
		public override byte get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22077;
		public override global::java.nio.ByteBuffer put(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22078;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort22079;
		public override short getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort22079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort22079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22080;
		public override short getShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort22080);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort22080);
		}
		internal static global::MonoJavaBridge.MethodId _putShort22081;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort22081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort22081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort22082;
		public override global::java.nio.ByteBuffer putShort(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort22082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort22082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar22083;
		public override char getChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar22083);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar22083);
		}
		internal static global::MonoJavaBridge.MethodId _getChar22084;
		public override char getChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar22084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar22084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar22085;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar22085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar22085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar22086;
		public override global::java.nio.ByteBuffer putChar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar22086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar22086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt22087;
		public override int getInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt22087);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt22087);
		}
		internal static global::MonoJavaBridge.MethodId _getInt22088;
		public override int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22089;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt22089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt22089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt22090;
		public override global::java.nio.ByteBuffer putInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong22091;
		public override long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong22091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong22091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22092;
		public override long getLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong22092);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong22092);
		}
		internal static global::MonoJavaBridge.MethodId _putLong22093;
		public override global::java.nio.ByteBuffer putLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong22094;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong22094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong22094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22095;
		public override float getFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat22095);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat22095);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22096;
		public override float getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat22096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat22096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22097;
		public override global::java.nio.ByteBuffer putFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat22097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat22097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22098;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat22098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat22098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22099;
		public override double getDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble22099);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble22099);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22100;
		public override double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble22100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble22100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22101;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble22101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble22101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22102;
		public override global::java.nio.ByteBuffer putDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble22102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble22102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22103;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isDirect22103);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isDirect22103);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22104;
		public override global::java.nio.ByteBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._duplicate22104)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._duplicate22104)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22105;
		public override global::java.nio.ByteBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._slice22105)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._slice22105)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22106;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asReadOnlyBuffer22106)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asReadOnlyBuffer22106)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22107;
		public override global::java.nio.ByteBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._compact22107)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._compact22107)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22108;
		public override global::java.nio.CharBuffer asCharBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asCharBuffer22108)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asCharBuffer22108)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22109;
		public override global::java.nio.ShortBuffer asShortBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asShortBuffer22109)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asShortBuffer22109)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22110;
		public override global::java.nio.IntBuffer asIntBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asIntBuffer22110)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asIntBuffer22110)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22111;
		public override global::java.nio.LongBuffer asLongBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asLongBuffer22111)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asLongBuffer22111)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22112;
		public override global::java.nio.FloatBuffer asFloatBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asFloatBuffer22112)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asFloatBuffer22112)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22113;
		public override global::java.nio.DoubleBuffer asDoubleBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asDoubleBuffer22113)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asDoubleBuffer22113)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22114;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isReadOnly22114);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isReadOnly22114);
		}
		static ByteBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer_._get22075 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "()B");
			global::java.nio.ByteBuffer_._get22076 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer_._put22077 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._put22078 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getShort22079 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer_._getShort22080 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer_._putShort22081 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putShort22082 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getChar22083 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer_._getChar22084 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer_._putChar22085 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putChar22086 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getInt22087 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer_._getInt22088 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer_._putInt22089 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putInt22090 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getLong22091 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer_._getLong22092 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer_._putLong22093 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putLong22094 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getFloat22095 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer_._getFloat22096 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer_._putFloat22097 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putFloat22098 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getDouble22099 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer_._getDouble22100 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer_._putDouble22101 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putDouble22102 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._isDirect22103 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer_._duplicate22104 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._slice22105 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asReadOnlyBuffer22106 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._compact22107 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asCharBuffer22108 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer_._asShortBuffer22109 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer_._asIntBuffer22110 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer_._asLongBuffer22111 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer_._asFloatBuffer22112 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer_._asDoubleBuffer22113 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.ByteBuffer_._isReadOnly22114 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
