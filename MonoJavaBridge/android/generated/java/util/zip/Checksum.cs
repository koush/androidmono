namespace java.util.zip
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.zip.Checksum_))]
	public partial interface Checksum  : global::MonoJavaBridge.IJavaObject 
	{
		long getValue();
		void reset();
		void update(int arg0);
		void update(byte[] arg0, int arg1, int arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.zip.Checksum))]
	internal sealed partial class Checksum_ : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Checksum_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		long java.util.zip.Checksum.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Checksum_.staticClass, "getValue", "()J", ref global::java.util.zip.Checksum_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.util.zip.Checksum.reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Checksum_.staticClass, "reset", "()V", ref global::java.util.zip.Checksum_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.util.zip.Checksum.update(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Checksum_.staticClass, "update", "(I)V", ref global::java.util.zip.Checksum_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.util.zip.Checksum.update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Checksum_.staticClass, "update", "([BII)V", ref global::java.util.zip.Checksum_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static Checksum_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Checksum_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Checksum"));
		}
	}
}
