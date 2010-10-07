namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ResourceCursorTreeAdapterScopeChangeShim : android.widget.CursorTreeAdapter
	{
		internal new static global::java.lang.Class staticClass;
		static ResourceCursorTreeAdapterScopeChangeShim()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ResourceCursorTreeAdapterScopeChangeShim(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _newGroupView11449;
		protected override global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newGroupView11449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newGroupView11449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newChildView11450;
		protected override global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newChildView11450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newChildView11450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass = @__class;
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newGroupView11449 = @__env.GetMethodID(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newChildView11450 = @__env.GetMethodID(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
		}
	}
}
