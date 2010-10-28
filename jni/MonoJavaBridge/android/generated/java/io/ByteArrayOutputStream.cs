namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteArrayOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18844;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toString18844)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toString18844)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString18845;
		public virtual global::java.lang.String toString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toString18845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toString18845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString18846;
		public virtual global::java.lang.String toString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toString18846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toString18846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size18847;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._size18847);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._size18847);
		}
		internal static global::MonoJavaBridge.MethodId _write18848;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._write18848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._write18848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18849;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._write18849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._write18849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close18850;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._close18850);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._close18850);
		}
		internal static global::MonoJavaBridge.MethodId _reset18851;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._reset18851);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._reset18851);
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray18852;
		public virtual byte[] toByteArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._toByteArray18852)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._toByteArray18852)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _writeTo18853;
		public virtual void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream._writeTo18853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._writeTo18853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayOutputStream18854;
		public ByteArrayOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18854);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayOutputStream18855;
		public ByteArrayOutputStream(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayOutputStream"));
			global::java.io.ByteArrayOutputStream._toString18844 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.ByteArrayOutputStream._toString18845 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.io.ByteArrayOutputStream._toString18846 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.io.ByteArrayOutputStream._size18847 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "size", "()I");
			global::java.io.ByteArrayOutputStream._write18848 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "write", "([BII)V");
			global::java.io.ByteArrayOutputStream._write18849 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "write", "(I)V");
			global::java.io.ByteArrayOutputStream._close18850 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "close", "()V");
			global::java.io.ByteArrayOutputStream._reset18851 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "reset", "()V");
			global::java.io.ByteArrayOutputStream._toByteArray18852 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "toByteArray", "()[B");
			global::java.io.ByteArrayOutputStream._writeTo18853 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18854 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "()V");
			global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18855 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
