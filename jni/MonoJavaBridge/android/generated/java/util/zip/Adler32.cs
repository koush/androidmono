namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Adler32 : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Adler32()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getValue28208;
		public virtual long getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Adler32._getValue28208);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._getValue28208);
		}
		internal static global::MonoJavaBridge.MethodId _reset28209;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._reset28209);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._reset28209);
		}
		internal static global::MonoJavaBridge.MethodId _update28210;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._update28210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._update28210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28211;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._update28211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._update28211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update28212;
		public virtual void update(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._update28212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._update28212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Adler3228213;
		public Adler32()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._Adler3228213);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Adler32.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Adler32"));
			global::java.util.zip.Adler32._getValue28208 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "getValue", "()J");
			global::java.util.zip.Adler32._reset28209 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "reset", "()V");
			global::java.util.zip.Adler32._update28210 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "update", "([B)V");
			global::java.util.zip.Adler32._update28211 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "update", "([BII)V");
			global::java.util.zip.Adler32._update28212 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "update", "(I)V");
			global::java.util.zip.Adler32._Adler3228213 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "<init>", "()V");
		}
	}
}
