namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.AlignmentSpan_))]
	public interface AlignmentSpan : ParagraphStyle
	{
		global::android.text.Layout.Alignment getAlignment();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.AlignmentSpan))]
	public sealed partial class AlignmentSpan_ : java.lang.Object, AlignmentSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlignmentSpan_()
		{
			InitJNI();
		}
		internal AlignmentSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment13379;
		 global::android.text.Layout.Alignment android.text.style.AlignmentSpan.getAlignment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_._getAlignment13379)) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_.staticClass, global::android.text.style.AlignmentSpan_._getAlignment13379)) as android.text.Layout.Alignment;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AlignmentSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AlignmentSpan"));
			global::android.text.style.AlignmentSpan_._getAlignment13379 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
		}
	}
}
