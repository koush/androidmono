namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PipedReader()
		{
			InitJNI();
		}
		protected PipedReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13766;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedReader._close13766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._close13766);
		}
		internal static global::MonoJavaBridge.MethodId _read13767;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedReader._read13767);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._read13767);
		}
		internal static global::MonoJavaBridge.MethodId _read13768;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedReader._read13768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._read13768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _connect13769;
		public virtual void connect(java.io.PipedWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedReader._connect13769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._connect13769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ready13770;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PipedReader._ready13770);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._ready13770);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader13771;
		public PipedReader(java.io.PipedWriter arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader13771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader13772;
		public PipedReader(java.io.PipedWriter arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader13772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader13773;
		public PipedReader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader13773);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader13774;
		public PipedReader(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader13774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedReader"));
			global::java.io.PipedReader._close13766 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "close", "()V");
			global::java.io.PipedReader._read13767 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "read", "()I");
			global::java.io.PipedReader._read13768 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "read", "([CII)I");
			global::java.io.PipedReader._connect13769 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "connect", "(Ljava/io/PipedWriter;)V");
			global::java.io.PipedReader._ready13770 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "ready", "()Z");
			global::java.io.PipedReader._PipedReader13771 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;)V");
			global::java.io.PipedReader._PipedReader13772 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;I)V");
			global::java.io.PipedReader._PipedReader13773 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "()V");
			global::java.io.PipedReader._PipedReader13774 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(I)V");
		}
	}
}
