namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringReader()
		{
			InitJNI();
		}
		protected StringReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13984;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._close13984);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._close13984);
		}
		internal static global::MonoJavaBridge.MethodId _mark13985;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._mark13985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._mark13985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13986;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._reset13986);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._reset13986);
		}
		internal static global::MonoJavaBridge.MethodId _read13987;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringReader._read13987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._read13987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13988;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringReader._read13988);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._read13988);
		}
		internal static global::MonoJavaBridge.MethodId _skip13989;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.StringReader._skip13989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._skip13989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13990;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.StringReader._markSupported13990);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._markSupported13990);
		}
		internal static global::MonoJavaBridge.MethodId _ready13991;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.StringReader._ready13991);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._ready13991);
		}
		internal static global::MonoJavaBridge.MethodId _StringReader13992;
		public StringReader(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringReader.staticClass, global::java.io.StringReader._StringReader13992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringReader"));
			global::java.io.StringReader._close13984 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "close", "()V");
			global::java.io.StringReader._mark13985 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "mark", "(I)V");
			global::java.io.StringReader._reset13986 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "reset", "()V");
			global::java.io.StringReader._read13987 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "read", "([CII)I");
			global::java.io.StringReader._read13988 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "read", "()I");
			global::java.io.StringReader._skip13989 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "skip", "(J)J");
			global::java.io.StringReader._markSupported13990 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "markSupported", "()Z");
			global::java.io.StringReader._ready13991 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "ready", "()Z");
			global::java.io.StringReader._StringReader13992 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
