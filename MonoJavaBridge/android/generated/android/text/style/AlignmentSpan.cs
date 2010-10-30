namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.AlignmentSpan_))]
	public partial interface AlignmentSpan : ParagraphStyle
	{
		global::android.text.Layout.Alignment getAlignment();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.AlignmentSpan))]
	internal sealed partial class AlignmentSpan_ : java.lang.Object, AlignmentSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlignmentSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment13441;
		global::android.text.Layout.Alignment android.text.style.AlignmentSpan.getAlignment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_._getAlignment13441)) as android.text.Layout.Alignment;
		}
		static AlignmentSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AlignmentSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AlignmentSpan"));
			global::android.text.style.AlignmentSpan_._getAlignment13441 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
		}
		internal static void InitJNI()
		{
		}
	}
}
