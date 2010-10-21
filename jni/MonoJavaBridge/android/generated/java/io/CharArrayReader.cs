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
		internal static global::MonoJavaBridge.MethodId _close18738;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayReader._close18738);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._close18738);
		}
		internal static global::MonoJavaBridge.MethodId _mark18739;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayReader._mark18739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._mark18739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18740;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayReader._reset18740);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._reset18740);
		}
		internal static global::MonoJavaBridge.MethodId _read18741;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.CharArrayReader._read18741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._read18741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18742;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.CharArrayReader._read18742);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._read18742);
		}
		internal static global::MonoJavaBridge.MethodId _skip18743;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.CharArrayReader._skip18743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._skip18743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18744;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader._markSupported18744);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._markSupported18744);
		}
		internal static global::MonoJavaBridge.MethodId _ready18745;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader._ready18745);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._ready18745);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayReader18746;
		public CharArrayReader(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._CharArrayReader18746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayReader18747;
		public CharArrayReader(char[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._CharArrayReader18747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayReader"));
			global::java.io.CharArrayReader._close18738 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "close", "()V");
			global::java.io.CharArrayReader._mark18739 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "mark", "(I)V");
			global::java.io.CharArrayReader._reset18740 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "reset", "()V");
			global::java.io.CharArrayReader._read18741 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "read", "([CII)I");
			global::java.io.CharArrayReader._read18742 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "read", "()I");
			global::java.io.CharArrayReader._skip18743 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "skip", "(J)J");
			global::java.io.CharArrayReader._markSupported18744 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "markSupported", "()Z");
			global::java.io.CharArrayReader._ready18745 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "ready", "()Z");
			global::java.io.CharArrayReader._CharArrayReader18746 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([C)V");
			global::java.io.CharArrayReader._CharArrayReader18747 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([CII)V");
		}
	}
}
