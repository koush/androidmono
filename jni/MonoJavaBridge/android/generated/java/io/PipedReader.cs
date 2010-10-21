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
		internal static global::MonoJavaBridge.MethodId _close19268;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedReader._close19268);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._close19268);
		}
		internal static global::MonoJavaBridge.MethodId _read19269;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedReader._read19269);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._read19269);
		}
		internal static global::MonoJavaBridge.MethodId _read19270;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedReader._read19270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._read19270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _connect19271;
		public virtual void connect(java.io.PipedWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedReader._connect19271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._connect19271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ready19272;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PipedReader._ready19272);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PipedReader.staticClass, global::java.io.PipedReader._ready19272);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19273;
		public PipedReader(java.io.PipedWriter arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19274;
		public PipedReader(java.io.PipedWriter arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19275;
		public PipedReader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19275);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19276;
		public PipedReader(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedReader"));
			global::java.io.PipedReader._close19268 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "close", "()V");
			global::java.io.PipedReader._read19269 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "read", "()I");
			global::java.io.PipedReader._read19270 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "read", "([CII)I");
			global::java.io.PipedReader._connect19271 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "connect", "(Ljava/io/PipedWriter;)V");
			global::java.io.PipedReader._ready19272 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "ready", "()Z");
			global::java.io.PipedReader._PipedReader19273 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;)V");
			global::java.io.PipedReader._PipedReader19274 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;I)V");
			global::java.io.PipedReader._PipedReader19275 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "()V");
			global::java.io.PipedReader._PipedReader19276 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(I)V");
		}
	}
}
