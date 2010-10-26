namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.MappedByteBuffer_))]
	public abstract partial class MappedByteBuffer : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MappedByteBuffer()
		{
			InitJNI();
		}
		protected MappedByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load22316;
		public virtual global::java.nio.MappedByteBuffer load() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._load22316)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._load22316)) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isLoaded22317;
		public virtual bool isLoaded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._isLoaded22317);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._isLoaded22317);
		}
		internal static global::MonoJavaBridge.MethodId _force22318;
		public virtual global::java.nio.MappedByteBuffer force() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._force22318)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._force22318)) as java.nio.MappedByteBuffer;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer._load22316 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;");
			global::java.nio.MappedByteBuffer._isLoaded22317 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z");
			global::java.nio.MappedByteBuffer._force22318 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.MappedByteBuffer))]
	internal sealed partial class MappedByteBuffer_ : java.nio.MappedByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MappedByteBuffer_()
		{
			InitJNI();
		}
		internal MappedByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22319;
		public override byte get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get22319);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get22319);
		}
		internal static global::MonoJavaBridge.MethodId _get22320;
		public override byte get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get22320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get22320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22321;
		public override global::java.nio.ByteBuffer put(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put22321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put22321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22322;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put22322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put22322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort22323;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort22323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort22323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22324;
		public override short getShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort22324);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort22324);
		}
		internal static global::MonoJavaBridge.MethodId _putShort22325;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort22325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort22325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort22326;
		public override global::java.nio.ByteBuffer putShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort22326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort22326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar22327;
		public override char getChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar22327);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar22327);
		}
		internal static global::MonoJavaBridge.MethodId _getChar22328;
		public override char getChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar22328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar22328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar22329;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar22329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar22329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar22330;
		public override global::java.nio.ByteBuffer putChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar22330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar22330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt22331;
		public override int getInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt22331);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt22331);
		}
		internal static global::MonoJavaBridge.MethodId _getInt22332;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt22332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt22332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22333;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt22333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt22333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt22334;
		public override global::java.nio.ByteBuffer putInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt22334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt22334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong22335;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong22335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong22335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22336;
		public override long getLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong22336);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong22336);
		}
		internal static global::MonoJavaBridge.MethodId _putLong22337;
		public override global::java.nio.ByteBuffer putLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong22337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong22337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong22338;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong22338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong22338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22339;
		public override float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat22339);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat22339);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22340;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat22340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat22340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22341;
		public override global::java.nio.ByteBuffer putFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat22341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat22341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22342;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat22342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat22342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22343;
		public override double getDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble22343);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble22343);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22344;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble22344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble22344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22345;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble22345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble22345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22346;
		public override global::java.nio.ByteBuffer putDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble22346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble22346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22347;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isDirect22347);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isDirect22347);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22348;
		public override global::java.nio.ByteBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._duplicate22348)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._duplicate22348)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22349;
		public override global::java.nio.ByteBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._slice22349)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._slice22349)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22350;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22350)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22350)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22351;
		public override global::java.nio.ByteBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._compact22351)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._compact22351)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22352;
		public override global::java.nio.CharBuffer asCharBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asCharBuffer22352)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asCharBuffer22352)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22353;
		public override global::java.nio.ShortBuffer asShortBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asShortBuffer22353)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asShortBuffer22353)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22354;
		public override global::java.nio.IntBuffer asIntBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asIntBuffer22354)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asIntBuffer22354)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22355;
		public override global::java.nio.LongBuffer asLongBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asLongBuffer22355)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asLongBuffer22355)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22356;
		public override global::java.nio.FloatBuffer asFloatBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asFloatBuffer22356)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asFloatBuffer22356)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22357;
		public override global::java.nio.DoubleBuffer asDoubleBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asDoubleBuffer22357)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asDoubleBuffer22357)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22358;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isReadOnly22358);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isReadOnly22358);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer_._get22319 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "()B");
			global::java.nio.MappedByteBuffer_._get22320 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.MappedByteBuffer_._put22321 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._put22322 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getShort22323 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.MappedByteBuffer_._getShort22324 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.MappedByteBuffer_._putShort22325 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putShort22326 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getChar22327 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.MappedByteBuffer_._getChar22328 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.MappedByteBuffer_._putChar22329 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putChar22330 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getInt22331 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.MappedByteBuffer_._getInt22332 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.MappedByteBuffer_._putInt22333 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putInt22334 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getLong22335 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.MappedByteBuffer_._getLong22336 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.MappedByteBuffer_._putLong22337 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putLong22338 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getFloat22339 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.MappedByteBuffer_._getFloat22340 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.MappedByteBuffer_._putFloat22341 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putFloat22342 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getDouble22343 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.MappedByteBuffer_._getDouble22344 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.MappedByteBuffer_._putDouble22345 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putDouble22346 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._isDirect22347 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.MappedByteBuffer_._duplicate22348 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._slice22349 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22350 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._compact22351 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asCharBuffer22352 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.MappedByteBuffer_._asShortBuffer22353 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.MappedByteBuffer_._asIntBuffer22354 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.MappedByteBuffer_._asLongBuffer22355 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.MappedByteBuffer_._asFloatBuffer22356 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.MappedByteBuffer_._asDoubleBuffer22357 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.MappedByteBuffer_._isReadOnly22358 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
