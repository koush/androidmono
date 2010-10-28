namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CRC32 : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CRC32(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new long Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue28333;
		public virtual long getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.CRC32._getValue28333);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._getValue28333);
		}
		internal static global::MonoJavaBridge.MethodId _reset28334;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._reset28334);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._reset28334);
		}
		internal static global::MonoJavaBridge.MethodId _update28335;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update28335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update28335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28336;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update28336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update28336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update28337;
		public virtual void update(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update28337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update28337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CRC3228338;
		public CRC32() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._CRC3228338);
			Init(@__env, handle);
		}
		static CRC32()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CRC32.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CRC32"));
			global::java.util.zip.CRC32._getValue28333 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "getValue", "()J");
			global::java.util.zip.CRC32._reset28334 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "reset", "()V");
			global::java.util.zip.CRC32._update28335 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "([B)V");
			global::java.util.zip.CRC32._update28336 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "([BII)V");
			global::java.util.zip.CRC32._update28337 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "(I)V");
			global::java.util.zip.CRC32._CRC3228338 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
