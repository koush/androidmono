namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Base64OutputStream : java.io.FilterOutputStream
	{
		internal static global::java.lang.Class staticClass;
		static Base64OutputStream()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Base64OutputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.Base64OutputStream(@__env);
			}
		}
		protected Base64OutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _write8177;
		public override void write(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.Base64OutputStream._write8177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write8177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write8178;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.Base64OutputStream._write8178, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write8178, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close8179;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.Base64OutputStream._close8179);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._close8179);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Base64OutputStream8180;
		public Base64OutputStream(java.io.OutputStream arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._Base64OutputStream8180, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.Base64OutputStream.staticClass = @__class;
			global::android.util.Base64OutputStream._write8177 = @__env.GetMethodID(global::android.util.Base64OutputStream.staticClass, "write", "(I)V");
			global::android.util.Base64OutputStream._write8178 = @__env.GetMethodID(global::android.util.Base64OutputStream.staticClass, "write", "([BII)V");
			global::android.util.Base64OutputStream._close8179 = @__env.GetMethodID(global::android.util.Base64OutputStream.staticClass, "close", "()V");
			global::android.util.Base64OutputStream._Base64OutputStream8180 = @__env.GetMethodID(global::android.util.Base64OutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
		}
	}
}
