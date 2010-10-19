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
		internal static global::MonoJavaBridge.MethodId _load16604;
		public virtual global::java.nio.MappedByteBuffer load() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._load16604)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._load16604)) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isLoaded16605;
		public virtual bool isLoaded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._isLoaded16605);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._isLoaded16605);
		}
		internal static global::MonoJavaBridge.MethodId _force16606;
		public virtual global::java.nio.MappedByteBuffer force() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer._force16606)) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._force16606)) as java.nio.MappedByteBuffer;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer._load16604 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;");
			global::java.nio.MappedByteBuffer._isLoaded16605 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z");
			global::java.nio.MappedByteBuffer._force16606 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;");
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
		internal static global::MonoJavaBridge.MethodId _get16607;
		public override byte get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get16607);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get16607);
		}
		internal static global::MonoJavaBridge.MethodId _get16608;
		public override byte get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._get16608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._get16608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16609;
		public override global::java.nio.ByteBuffer put(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put16609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put16609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16610;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._put16610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._put16610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort16611;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort16611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort16611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort16612;
		public override short getShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getShort16612);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getShort16612);
		}
		internal static global::MonoJavaBridge.MethodId _putShort16613;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort16613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort16613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort16614;
		public override global::java.nio.ByteBuffer putShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putShort16614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putShort16614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar16615;
		public override char getChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar16615);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar16615);
		}
		internal static global::MonoJavaBridge.MethodId _getChar16616;
		public override char getChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getChar16616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getChar16616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar16617;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar16617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar16617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar16618;
		public override global::java.nio.ByteBuffer putChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putChar16618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putChar16618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt16619;
		public override int getInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt16619);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt16619);
		}
		internal static global::MonoJavaBridge.MethodId _getInt16620;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getInt16620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getInt16620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt16621;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt16621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt16621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt16622;
		public override global::java.nio.ByteBuffer putInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putInt16622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putInt16622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong16623;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong16623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong16623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong16624;
		public override long getLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getLong16624);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getLong16624);
		}
		internal static global::MonoJavaBridge.MethodId _putLong16625;
		public override global::java.nio.ByteBuffer putLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong16625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong16625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong16626;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putLong16626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putLong16626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat16627;
		public override float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat16627);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat16627);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat16628;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getFloat16628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getFloat16628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat16629;
		public override global::java.nio.ByteBuffer putFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat16629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat16629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat16630;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putFloat16630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putFloat16630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble16631;
		public override double getDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble16631);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble16631);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble16632;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._getDouble16632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._getDouble16632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble16633;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble16633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble16633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble16634;
		public override global::java.nio.ByteBuffer putDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._putDouble16634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._putDouble16634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16635;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isDirect16635);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isDirect16635);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16636;
		public override global::java.nio.ByteBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._duplicate16636)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._duplicate16636)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16637;
		public override global::java.nio.ByteBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._slice16637)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._slice16637)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16638;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer16638)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asReadOnlyBuffer16638)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16639;
		public override global::java.nio.ByteBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._compact16639)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._compact16639)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer16640;
		public override global::java.nio.CharBuffer asCharBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asCharBuffer16640)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asCharBuffer16640)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer16641;
		public override global::java.nio.ShortBuffer asShortBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asShortBuffer16641)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asShortBuffer16641)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer16642;
		public override global::java.nio.IntBuffer asIntBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asIntBuffer16642)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asIntBuffer16642)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer16643;
		public override global::java.nio.LongBuffer asLongBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asLongBuffer16643)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asLongBuffer16643)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer16644;
		public override global::java.nio.FloatBuffer asFloatBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asFloatBuffer16644)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asFloatBuffer16644)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer16645;
		public override global::java.nio.DoubleBuffer asDoubleBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._asDoubleBuffer16645)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._asDoubleBuffer16645)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16646;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_._isReadOnly16646);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.MappedByteBuffer_.staticClass, global::java.nio.MappedByteBuffer_._isReadOnly16646);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
			global::java.nio.MappedByteBuffer_._get16607 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "()B");
			global::java.nio.MappedByteBuffer_._get16608 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.MappedByteBuffer_._put16609 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._put16610 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getShort16611 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.MappedByteBuffer_._getShort16612 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.MappedByteBuffer_._putShort16613 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putShort16614 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getChar16615 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.MappedByteBuffer_._getChar16616 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.MappedByteBuffer_._putChar16617 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putChar16618 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getInt16619 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.MappedByteBuffer_._getInt16620 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.MappedByteBuffer_._putInt16621 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putInt16622 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getLong16623 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.MappedByteBuffer_._getLong16624 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.MappedByteBuffer_._putLong16625 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putLong16626 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getFloat16627 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.MappedByteBuffer_._getFloat16628 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.MappedByteBuffer_._putFloat16629 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putFloat16630 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._getDouble16631 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.MappedByteBuffer_._getDouble16632 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.MappedByteBuffer_._putDouble16633 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._putDouble16634 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._isDirect16635 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.MappedByteBuffer_._duplicate16636 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._slice16637 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asReadOnlyBuffer16638 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._compact16639 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.MappedByteBuffer_._asCharBuffer16640 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.MappedByteBuffer_._asShortBuffer16641 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.MappedByteBuffer_._asIntBuffer16642 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.MappedByteBuffer_._asLongBuffer16643 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.MappedByteBuffer_._asFloatBuffer16644 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.MappedByteBuffer_._asDoubleBuffer16645 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.MappedByteBuffer_._isReadOnly16646 = @__env.GetMethodIDNoThrow(global::java.nio.MappedByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
