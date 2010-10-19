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
		internal static global::MonoJavaBridge.MethodId _readLine13226;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.BufferedReader._readLine13226)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._readLine13226)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13227;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedReader._close13227);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._close13227);
		}
		internal static global::MonoJavaBridge.MethodId _mark13228;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedReader._mark13228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._mark13228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13229;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedReader._reset13229);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._reset13229);
		}
		internal static global::MonoJavaBridge.MethodId _read13230;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedReader._read13230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read13230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13231;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedReader._read13231);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read13231);
		}
		internal static global::MonoJavaBridge.MethodId _skip13232;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.BufferedReader._skip13232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._skip13232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13233;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedReader._markSupported13233);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._markSupported13233);
		}
		internal static global::MonoJavaBridge.MethodId _ready13234;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedReader._ready13234);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._ready13234);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedReader13235;
		public BufferedReader(java.io.Reader arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader13235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedReader13236;
		public BufferedReader(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader13236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedReader"));
			global::java.io.BufferedReader._readLine13226 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.BufferedReader._close13227 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "close", "()V");
			global::java.io.BufferedReader._mark13228 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "mark", "(I)V");
			global::java.io.BufferedReader._reset13229 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "reset", "()V");
			global::java.io.BufferedReader._read13230 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "read", "([CII)I");
			global::java.io.BufferedReader._read13231 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "read", "()I");
			global::java.io.BufferedReader._skip13232 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "skip", "(J)J");
			global::java.io.BufferedReader._markSupported13233 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "markSupported", "()Z");
			global::java.io.BufferedReader._ready13234 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "ready", "()Z");
			global::java.io.BufferedReader._BufferedReader13235 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.BufferedReader._BufferedReader13236 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
