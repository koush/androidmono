namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.SpanWatcher_))]
	public partial interface SpanWatcher : NoCopySpan
	{
		void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3);
		void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3);
		void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.SpanWatcher))]
	internal sealed partial class SpanWatcher_ : java.lang.Object, SpanWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpanWatcher_()
		{
			InitJNI();
		}
		internal SpanWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSpanAdded12927;
		void android.text.SpanWatcher.onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpanWatcher_._onSpanAdded12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpanWatcher_.staticClass, global::android.text.SpanWatcher_._onSpanAdded12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanRemoved12928;
		void android.text.SpanWatcher.onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpanWatcher_._onSpanRemoved12928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpanWatcher_.staticClass, global::android.text.SpanWatcher_._onSpanRemoved12928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanChanged12929;
		void android.text.SpanWatcher.onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpanWatcher_._onSpanChanged12929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpanWatcher_.staticClass, global::android.text.SpanWatcher_._onSpanChanged12929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpanWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpanWatcher"));
			global::android.text.SpanWatcher_._onSpanAdded12927 = @__env.GetMethodIDNoThrow(global::android.text.SpanWatcher_.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.SpanWatcher_._onSpanRemoved12928 = @__env.GetMethodIDNoThrow(global::android.text.SpanWatcher_.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.SpanWatcher_._onSpanChanged12929 = @__env.GetMethodIDNoThrow(global::android.text.SpanWatcher_.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V");
		}
	}
}
