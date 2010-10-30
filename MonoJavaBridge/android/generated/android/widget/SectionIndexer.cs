namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SectionIndexer_))]
	public partial interface SectionIndexer  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getSections();
		int getPositionForSection(int arg0);
		int getSectionForPosition(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SectionIndexer))]
	internal sealed partial class SectionIndexer_ : java.lang.Object, SectionIndexer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SectionIndexer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSections17733;
		global::java.lang.Object[] android.widget.SectionIndexer.getSections()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.widget.SectionIndexer_.staticClass, "getSections", "()[Ljava/lang/Object;", ref global::android.widget.SectionIndexer_._getSections17733) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getPositionForSection17734;
		int android.widget.SectionIndexer.getPositionForSection(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SectionIndexer_.staticClass, "getPositionForSection", "(I)I", ref global::android.widget.SectionIndexer_._getPositionForSection17734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSectionForPosition17735;
		int android.widget.SectionIndexer.getSectionForPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SectionIndexer_.staticClass, "getSectionForPosition", "(I)I", ref global::android.widget.SectionIndexer_._getSectionForPosition17735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SectionIndexer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SectionIndexer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SectionIndexer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
