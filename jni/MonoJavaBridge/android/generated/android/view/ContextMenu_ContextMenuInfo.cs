namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ContextMenu_ContextMenuInfo_))]
	public partial interface ContextMenu_ContextMenuInfo  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ContextMenu_ContextMenuInfo))]
	internal sealed partial class ContextMenu_ContextMenuInfo_ : java.lang.Object, ContextMenu_ContextMenuInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContextMenu_ContextMenuInfo_()
		{
			InitJNI();
		}
		internal ContextMenu_ContextMenuInfo_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextMenu_ContextMenuInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextMenu$ContextMenuInfo"));
		}
	}
}
