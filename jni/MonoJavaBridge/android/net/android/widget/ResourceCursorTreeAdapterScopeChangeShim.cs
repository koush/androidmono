namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ResourceCursorTreeAdapterScopeChangeShim : android.widget.CursorTreeAdapter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ResourceCursorTreeAdapterScopeChangeShim() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ResourceCursorTreeAdapterScopeChangeShim), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ResourceCursorTreeAdapterScopeChangeShim(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newGroupView9961; 
		protected override android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ResourceCursorTreeAdapterScopeChangeShim)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newGroupView9961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, _newGroupView9961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newChildView9962; 
		protected override android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ResourceCursorTreeAdapterScopeChangeShim)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newChildView9962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, _newChildView9962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass = @__class; 
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newGroupView9961 = @__env.GetMethodID(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._newChildView9962 = @__env.GetMethodID(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
		} 
	} 
} 
