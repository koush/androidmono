namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FocusFinder : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FocusFinder()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.FocusFinder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.FocusFinder(@__env);
			}
		}
		protected FocusFinder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8420;
		public static global::android.view.FocusFinder getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.FocusFinder>(@__env, @__env.CallStaticObjectMethodPtr(android.view.FocusFinder.staticClass, global::android.view.FocusFinder._getInstance8420));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findNextFocus8421;
		public virtual global::android.view.View findNextFocus(android.view.ViewGroup arg0, android.view.View arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.FocusFinder._findNextFocus8421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.FocusFinder.staticClass, global::android.view.FocusFinder._findNextFocus8421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findNextFocusFromRect8422;
		public virtual global::android.view.View findNextFocusFromRect(android.view.ViewGroup arg0, android.graphics.Rect arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.FocusFinder._findNextFocusFromRect8422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.FocusFinder.staticClass, global::android.view.FocusFinder._findNextFocusFromRect8422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findNearestTouchable8423;
		public virtual global::android.view.View findNearestTouchable(android.view.ViewGroup arg0, int arg1, int arg2, int arg3, int[] arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.FocusFinder._findNearestTouchable8423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.FocusFinder.staticClass, global::android.view.FocusFinder._findNearestTouchable8423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.FocusFinder.staticClass = @__class;
			global::android.view.FocusFinder._getInstance8420 = @__env.GetStaticMethodID(global::android.view.FocusFinder.staticClass, "getInstance", "()Landroid/view/FocusFinder;");
			global::android.view.FocusFinder._findNextFocus8421 = @__env.GetMethodID(global::android.view.FocusFinder.staticClass, "findNextFocus", "(Landroid/view/ViewGroup;Landroid/view/View;I)Landroid/view/View;");
			global::android.view.FocusFinder._findNextFocusFromRect8422 = @__env.GetMethodID(global::android.view.FocusFinder.staticClass, "findNextFocusFromRect", "(Landroid/view/ViewGroup;Landroid/graphics/Rect;I)Landroid/view/View;");
			global::android.view.FocusFinder._findNearestTouchable8423 = @__env.GetMethodID(global::android.view.FocusFinder.staticClass, "findNearestTouchable", "(Landroid/view/ViewGroup;III[I)Landroid/view/View;");
		}
	}
}
