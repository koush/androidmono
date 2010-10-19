namespace java.util.zip
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.zip.Checksum_))]
	public interface Checksum  : global::MonoJavaBridge.IJavaObject 
	{
		long getValue();
		void reset();
		void update(int arg0);
		void update(byte[] arg0, int arg1, int arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.zip.Checksum))]
	public sealed partial class Checksum_ : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Checksum_()
		{
			InitJNI();
		}
		internal Checksum_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getValue22355;
		 long java.util.zip.Checksum.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Checksum_._getValue22355);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Checksum_.staticClass, global::java.util.zip.Checksum_._getValue22355);
		}
		internal static global::MonoJavaBridge.MethodId _reset22356;
		 void java.util.zip.Checksum.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Checksum_._reset22356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Checksum_.staticClass, global::java.util.zip.Checksum_._reset22356);
		}
		internal static global::MonoJavaBridge.MethodId _update22357;
		 void java.util.zip.Checksum.update(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Checksum_._update22357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Checksum_.staticClass, global::java.util.zip.Checksum_._update22357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update22358;
		 void java.util.zip.Checksum.update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Checksum_._update22358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Checksum_.staticClass, global::java.util.zip.Checksum_._update22358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Checksum_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Checksum"));
			global::java.util.zip.Checksum_._getValue22355 = @__env.GetMethodIDNoThrow(global::java.util.zip.Checksum_.staticClass, "getValue", "()J");
			global::java.util.zip.Checksum_._reset22356 = @__env.GetMethodIDNoThrow(global::java.util.zip.Checksum_.staticClass, "reset", "()V");
			global::java.util.zip.Checksum_._update22357 = @__env.GetMethodIDNoThrow(global::java.util.zip.Checksum_.staticClass, "update", "(I)V");
			global::java.util.zip.Checksum_._update22358 = @__env.GetMethodIDNoThrow(global::java.util.zip.Checksum_.staticClass, "update", "([BII)V");
		}
	}
}
