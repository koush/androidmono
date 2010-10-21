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
		internal static global::MonoJavaBridge.MethodId _load22198;
		public virtual global::java.nio.MappedByteBuffer load() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._load22198)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._load22198)) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isLoaded22199;
		public virtual bool isLoaded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._isLoaded22199);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._isLoaded22199);
		}
		internal static global::MonoJavaBridge.MethodId _force22200;
		public virtual global::java.nio.MappedByteBuffer force() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._force22200)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._force22200)) as java.nio.MappedByteBuffer;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer._load22198 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;");
			global::java.nio.MappedByteBuffer._isLoaded22199 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z");
			global::java.nio.MappedByteBuffer._force22200 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.MappedByteBuffer))]
	public sealed partial class MappedByteBuffer_ : java.nio.MappedByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MappedByteBuffer_()
		{
			InitJNI();
		}
		internal MappedByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22201;
		public override byte get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get22201);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get22201);
		}
		internal static global::MonoJavaBridge.MethodId _get22202;
		public override byte get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get22202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get22202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22203;
		public override global::java.nio.ByteBuffer put(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put22203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put22203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22204;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put22204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put22204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort22205;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort22205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort22205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22206;
		public override short getShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort22206);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort22206);
		}
		internal static global::MonoJavaBridge.MethodId _putShort22207;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort22207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort22207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort22208;
		public override global::java.nio.ByteBuffer putShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort22208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort22208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar22209;
		public override char getChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar22209);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar22209);
		}
		internal static global::MonoJavaBridge.MethodId _getChar22210;
		public override char getChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar22210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar22210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar22211;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar22211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar22211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar22212;
		public override global::java.nio.ByteBuffer putChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar22212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar22212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt22213;
		public override int getInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt22213);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt22213);
		}
		internal static global::MonoJavaBridge.MethodId _getInt22214;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt22214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt22214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22215;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt22215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt22215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt22216;
		public override global::java.nio.ByteBuffer putInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt22216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt22216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong22217;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong22217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong22217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22218;
		public override long getLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong22218);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong22218);
		}
		internal static global::MonoJavaBridge.MethodId _putLong22219;
		public override global::java.nio.ByteBuffer putLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong22219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong22219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong22220;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong22220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong22220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22221;
		public override float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat22221);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat22221);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22222;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat22222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat22222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22223;
		public override global::java.nio.ByteBuffer putFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat22223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat22223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22224;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat22224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat22224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22225;
		public override double getDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble22225);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble22225);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22226;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble22226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble22226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22227;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble22227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble22227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22228;
		public override global::java.nio.ByteBuffer putDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble22228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble22228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22229;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isDirect22229);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isDirect22229);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22230;
		public override global::java.nio.ByteBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._duplicate22230)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._duplicate22230)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22231;
		public override global::java.nio.ByteBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._slice22231)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._slice22231)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22232;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22232)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22232)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22233;
		public override global::java.nio.ByteBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._compact22233)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._compact22233)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22234;
		public override global::java.nio.CharBuffer asCharBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asCharBuffer22234)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asCharBuffer22234)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22235;
		public override global::java.nio.ShortBuffer asShortBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asShortBuffer22235)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asShortBuffer22235)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22236;
		public override global::java.nio.IntBuffer asIntBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asIntBuffer22236)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asIntBuffer22236)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22237;
		public override global::java.nio.LongBuffer asLongBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asLongBuffer22237)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asLongBuffer22237)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22238;
		public override global::java.nio.FloatBuffer asFloatBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asFloatBuffer22238)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asFloatBuffer22238)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22239;
		public override global::java.nio.DoubleBuffer asDoubleBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asDoubleBuffer22239)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asDoubleBuffer22239)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22240;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isReadOnly22240);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isReadOnly22240);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer_._get22201 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "()B");
			global::java.nio.MappedByteBuffer_._get22202 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.MappedByteBuffer_._put22203 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._put22204 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getShort22205 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.MappedByteBuffer_._getShort22206 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.MappedByteBuffer_._putShort22207 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putShort22208 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getChar22209 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.MappedByteBuffer_._getChar22210 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.MappedByteBuffer_._putChar22211 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putChar22212 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getInt22213 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.MappedByteBuffer_._getInt22214 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.MappedByteBuffer_._putInt22215 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putInt22216 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getLong22217 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.MappedByteBuffer_._getLong22218 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.MappedByteBuffer_._putLong22219 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putLong22220 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getFloat22221 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.MappedByteBuffer_._getFloat22222 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.MappedByteBuffer_._putFloat22223 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putFloat22224 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getDouble22225 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.MappedByteBuffer_._getDouble22226 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.MappedByteBuffer_._putDouble22227 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putDouble22228 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._isDirect22229 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.MappedByteBuffer_._duplicate22230 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._slice22231 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asReadOnlyBuffer22232 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._compact22233 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asCharBuffer22234 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.MappedByteBuffer_._asShortBuffer22235 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.MappedByteBuffer_._asIntBuffer22236 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.MappedByteBuffer_._asLongBuffer22237 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.MappedByteBuffer_._asFloatBuffer22238 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.MappedByteBuffer_._asDoubleBuffer22239 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.MappedByteBuffer_._isReadOnly22240 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
