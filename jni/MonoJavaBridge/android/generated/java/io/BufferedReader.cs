namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedReader()
		{
			InitJNI();
		}
		protected BufferedReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine18815;
		public virtual global::java.lang.String readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.BufferedReader._readLine18815)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._readLine18815)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close18816;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedReader._close18816);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._close18816);
		}
		internal static global::MonoJavaBridge.MethodId _mark18817;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedReader._mark18817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._mark18817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18818;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedReader._reset18818);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._reset18818);
		}
		internal static global::MonoJavaBridge.MethodId _read18819;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedReader._read18819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read18819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18820;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedReader._read18820);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read18820);
		}
		internal static global::MonoJavaBridge.MethodId _skip18821;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.BufferedReader._skip18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._skip18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18822;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedReader._markSupported18822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._markSupported18822);
		}
		internal static global::MonoJavaBridge.MethodId _ready18823;
		public override bool ready()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedReader._ready18823);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._ready18823);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedReader18824;
		public BufferedReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader18824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedReader18825;
		public BufferedReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader18825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedReader"));
			global::java.io.BufferedReader._readLine18815 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.BufferedReader._close18816 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "close", "()V");
			global::java.io.BufferedReader._mark18817 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "mark", "(I)V");
			global::java.io.BufferedReader._reset18818 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "reset", "()V");
			global::java.io.BufferedReader._read18819 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "read", "([CII)I");
			global::java.io.BufferedReader._read18820 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "read", "()I");
			global::java.io.BufferedReader._skip18821 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "skip", "(J)J");
			global::java.io.BufferedReader._markSupported18822 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "markSupported", "()Z");
			global::java.io.BufferedReader._ready18823 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "ready", "()Z");
			global::java.io.BufferedReader._BufferedReader18824 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.BufferedReader._BufferedReader18825 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
