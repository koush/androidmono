namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Adler32 : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Adler32(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new long Value
		{
			get
			{
				return getValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Adler32.staticClass, "getValue", "()J", ref global::java.util.zip.Adler32._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Adler32.staticClass, "reset", "()V", ref global::java.util.zip.Adler32._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Adler32.staticClass, "update", "([B)V", ref global::java.util.zip.Adler32._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Adler32.staticClass, "update", "([BII)V", ref global::java.util.zip.Adler32._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void update(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Adler32.staticClass, "update", "(I)V", ref global::java.util.zip.Adler32._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Adler32() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Adler32._m5.native == global::System.IntPtr.Zero)
				global::java.util.zip.Adler32._m5 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._m5);
			Init(@__env, handle);
		}
		static Adler32()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Adler32.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Adler32"));
		}
	}
}
