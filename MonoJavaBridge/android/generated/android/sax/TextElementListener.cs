namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.TextElementListener_))]
	public partial interface TextElementListener : StartElementListener, EndTextElementListener
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.TextElementListener))]
	internal sealed partial class TextElementListener_ : java.lang.Object, TextElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TextElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.TextElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V", ref global::android.sax.TextElementListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.sax.EndTextElementListener.end(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.TextElementListener_.staticClass, "end", "(Ljava/lang/String;)V", ref global::android.sax.TextElementListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TextElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.TextElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/TextElementListener"));
		}
	}
}
