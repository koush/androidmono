namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.MappedByteBuffer_))]
	public abstract partial class MappedByteBuffer : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MappedByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load22317;
		public virtual global::java.nio.MappedByteBuffer load()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._load22317)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._load22317)) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isLoaded22318;
		public virtual bool isLoaded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._isLoaded22318);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._isLoaded22318);
		}
		internal static global::MonoJavaBridge.MethodId _force22319;
		public virtual global::java.nio.MappedByteBuffer force()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._force22319)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._force22319)) as java.nio.MappedByteBuffer;
		}
		static MappedByteBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer._load22317 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;");
			global::java.nio.MappedByteBuffer._isLoaded22318 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z");
			global::java.nio.MappedByteBuffer._force22319 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.MappedByteBuffer))]
	internal sealed partial class MappedByteBuffer_ : java.nio.MappedByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MappedByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22320;
		public override byte get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get22320);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get22320);
		}
		internal static global::MonoJavaBridge.MethodId _get22321;
		public override byte get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get22321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get22321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22322;
		public override global::java.nio.ByteBuffer put(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put22322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put22322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22323;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put22323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put22323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort22324;
		public override short getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort22324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort22324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22325;
		public override short getShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort22325);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort22325);
		}
		internal static global::MonoJavaBridge.MethodId _putShort22326;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort22326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort22326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort22327;
		public override global::java.nio.ByteBuffer putShort(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort22327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort22327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar22328;
		public override char getChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar22328);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar22328);
		}
		internal static global::MonoJavaBridge.MethodId _getChar22329;
		public override char getChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar22329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar22329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar22330;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar22330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar22330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar22331;
		public override global::java.nio.ByteBuffer putChar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar22331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar22331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt22332;
		public override int getInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt22332);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt22332);
		}
		internal static global::MonoJavaBridge.MethodId _getInt22333;
		public override int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt22333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt22333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22334;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt22334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt22334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt22335;
		public override global::java.nio.ByteBuffer putInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt22335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt22335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong22336;
		public override long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong22336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong22336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22337;
		public override long getLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong22337);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong22337);
		}
		internal static global::MonoJavaBridge.MethodId _putLong22338;
		public override global::java.nio.ByteBuffer putLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong22338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong22338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong22339;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong22339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong22339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22340;
		public override float getFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat22340);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat22340);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22341;
		public override float getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat22341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat22341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22342;
		public override global::java.nio.ByteBuffer putFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat22342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat22342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22343;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat22343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat22343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22344;
		public override double getDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble22344);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble22344);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22345;
		public override double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble22345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble22345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22346;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble22346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble22346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22347;
		public override global::java.nio.ByteBuffer putDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble22347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble22347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22348;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isDirect22348);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isDirect22348);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22349;
		public override global::java.nio.ByteBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._duplicate22349)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._duplicate22349)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22350;
		public override global::java.nio.ByteBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._slice22350)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._slice22350)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22351;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22351)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22351)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22352;
		public override global::java.nio.ByteBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._compact22352)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._compact22352)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22353;
		public override global::java.nio.CharBuffer asCharBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asCharBuffer22353)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asCharBuffer22353)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22354;
		public override global::java.nio.ShortBuffer asShortBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asShortBuffer22354)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asShortBuffer22354)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22355;
		public override global::java.nio.IntBuffer asIntBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asIntBuffer22355)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asIntBuffer22355)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22356;
		public override global::java.nio.LongBuffer asLongBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asLongBuffer22356)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asLongBuffer22356)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22357;
		public override global::java.nio.FloatBuffer asFloatBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asFloatBuffer22357)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asFloatBuffer22357)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22358;
		public override global::java.nio.DoubleBuffer asDoubleBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asDoubleBuffer22358)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asDoubleBuffer22358)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22359;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isReadOnly22359);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isReadOnly22359);
		}
		static MappedByteBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer_._get22320 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "()B");
			global::java.nio.MappedByteBuffer_._get22321 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.MappedByteBuffer_._put22322 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._put22323 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getShort22324 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.MappedByteBuffer_._getShort22325 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.MappedByteBuffer_._putShort22326 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putShort22327 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getChar22328 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.MappedByteBuffer_._getChar22329 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.MappedByteBuffer_._putChar22330 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putChar22331 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getInt22332 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.MappedByteBuffer_._getInt22333 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.MappedByteBuffer_._putInt22334 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putInt22335 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getLong22336 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.MappedByteBuffer_._getLong22337 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.MappedByteBuffer_._putLong22338 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putLong22339 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getFloat22340 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.MappedByteBuffer_._getFloat22341 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.MappedByteBuffer_._putFloat22342 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putFloat22343 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getDouble22344 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.MappedByteBuffer_._getDouble22345 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.MappedByteBuffer_._putDouble22346 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putDouble22347 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._isDirect22348 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.MappedByteBuffer_._duplicate22349 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._slice22350 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22351 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._compact22352 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asCharBuffer22353 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.MappedByteBuffer_._asShortBuffer22354 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.MappedByteBuffer_._asIntBuffer22355 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.MappedByteBuffer_._asLongBuffer22356 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.MappedByteBuffer_._asFloatBuffer22357 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.MappedByteBuffer_._asDoubleBuffer22358 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.MappedByteBuffer_._isReadOnly22359 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
