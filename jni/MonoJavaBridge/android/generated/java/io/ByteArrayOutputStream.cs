namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteArrayOutputStream()
		{
			InitJNI();
		}
		protected ByteArrayOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13255;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toString13255)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toString13255)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString13256;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toString13256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toString13256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString13257;
		public virtual global::java.lang.String toString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toString13257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toString13257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size13258;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._size13258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._size13258);
		}
		internal static global::MonoJavaBridge.MethodId _write13259;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._write13259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._write13259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13260;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._write13260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._write13260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close13261;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._close13261);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._close13261);
		}
		internal static global::MonoJavaBridge.MethodId _reset13262;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._reset13262);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._reset13262);
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray13263;
		public virtual byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toByteArray13263)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toByteArray13263)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _writeTo13264;
		public virtual void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._writeTo13264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._writeTo13264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayOutputStream13265;
		public ByteArrayOutputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._ByteArrayOutputStream13265);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayOutputStream13266;
		public ByteArrayOutputStream(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._ByteArrayOutputStream13266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayOutputStream"));
			global::java.io.ByteArrayOutputStream._toString13255 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.ByteArrayOutputStream._toString13256 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.io.ByteArrayOutputStream._toString13257 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.io.ByteArrayOutputStream._size13258 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "size", "()I");
			global::java.io.ByteArrayOutputStream._write13259 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "write", "([BII)V");
			global::java.io.ByteArrayOutputStream._write13260 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "write", "(I)V");
			global::java.io.ByteArrayOutputStream._close13261 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "close", "()V");
			global::java.io.ByteArrayOutputStream._reset13262 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "reset", "()V");
			global::java.io.ByteArrayOutputStream._toByteArray13263 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toByteArray", "()[B");
			global::java.io.ByteArrayOutputStream._writeTo13264 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::java.io.ByteArrayOutputStream._ByteArrayOutputStream13265 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "()V");
			global::java.io.ByteArrayOutputStream._ByteArrayOutputStream13266 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "(I)V");
		}
	}
}
