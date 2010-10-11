namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SectionIndexer_))]
	public interface SectionIndexer  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getSections();
		int getPositionForSection(int arg0);
		int getSectionForPosition(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SectionIndexer))]
	public sealed partial class SectionIndexer_ : java.lang.Object, SectionIndexer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SectionIndexer_()
		{
			InitJNI();
		}
		internal SectionIndexer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSections11895;
		 global::java.lang.Object[] android.widget.SectionIndexer.getSections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SectionIndexer_._getSections11895)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SectionIndexer_.staticClass, global::android.widget.SectionIndexer_._getSections11895)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getPositionForSection11896;
		 int android.widget.SectionIndexer.getPositionForSection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SectionIndexer_._getPositionForSection11896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SectionIndexer_.staticClass, global::android.widget.SectionIndexer_._getPositionForSection11896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSectionForPosition11897;
		 int android.widget.SectionIndexer.getSectionForPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SectionIndexer_._getSectionForPosition11897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SectionIndexer_.staticClass, global::android.widget.SectionIndexer_._getSectionForPosition11897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SectionIndexer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SectionIndexer"));
			global::android.widget.SectionIndexer_._getSections11895 = @__env.GetMethodIDNoThrow(global::android.widget.SectionIndexer_.staticClass, "getSections", "()[Ljava/lang/Object;");
			global::android.widget.SectionIndexer_._getPositionForSection11896 = @__env.GetMethodIDNoThrow(global::android.widget.SectionIndexer_.staticClass, "getPositionForSection", "(I)I");
			global::android.widget.SectionIndexer_._getSectionForPosition11897 = @__env.GetMethodIDNoThrow(global::android.widget.SectionIndexer_.staticClass, "getSectionForPosition", "(I)I");
		}
	}
}
