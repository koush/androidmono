namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharArrayReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharArrayReader()
		{
			InitJNI();
		}
		protected CharArrayReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13267;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayReader._close13267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._close13267);
		}
		internal static global::MonoJavaBridge.MethodId _mark13268;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayReader._mark13268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._mark13268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13269;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayReader._reset13269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._reset13269);
		}
		internal static global::MonoJavaBridge.MethodId _read13270;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.CharArrayReader._read13270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._read13270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13271;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.CharArrayReader._read13271);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._read13271);
		}
		internal static global::MonoJavaBridge.MethodId _skip13272;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.CharArrayReader._skip13272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._skip13272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13273;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader._markSupported13273);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._markSupported13273);
		}
		internal static global::MonoJavaBridge.MethodId _ready13274;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader._ready13274);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._ready13274);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayReader13275;
		public CharArrayReader(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._CharArrayReader13275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayReader13276;
		public CharArrayReader(char[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._CharArrayReader13276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayReader"));
			global::java.io.CharArrayReader._close13267 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "close", "()V");
			global::java.io.CharArrayReader._mark13268 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "mark", "(I)V");
			global::java.io.CharArrayReader._reset13269 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "reset", "()V");
			global::java.io.CharArrayReader._read13270 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "read", "([CII)I");
			global::java.io.CharArrayReader._read13271 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "read", "()I");
			global::java.io.CharArrayReader._skip13272 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "skip", "(J)J");
			global::java.io.CharArrayReader._markSupported13273 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "markSupported", "()Z");
			global::java.io.CharArrayReader._ready13274 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "ready", "()Z");
			global::java.io.CharArrayReader._CharArrayReader13275 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([C)V");
			global::java.io.CharArrayReader._CharArrayReader13276 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([CII)V");
		}
	}
}
