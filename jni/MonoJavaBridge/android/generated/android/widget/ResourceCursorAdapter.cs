namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ResourceCursorAdapter : android.widget.CursorAdapter
	{
		internal new static global::java.lang.Class staticClass;
		static ResourceCursorAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ResourceCursorAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ResourceCursorAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource10726;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter._setDropDownViewResource10726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._setDropDownViewResource10726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newView10727;
		public override global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ResourceCursorAdapter._newView10727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._newView10727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newDropDownView10728;
		public override global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ResourceCursorAdapter._newDropDownView10728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._newDropDownView10728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewResource10729;
		public virtual void setViewResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter._setViewResource10729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._setViewResource10729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ResourceCursorAdapter10730;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter10730, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ResourceCursorAdapter10731;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter10731, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ResourceCursorAdapter.staticClass = @__class;
			global::android.widget.ResourceCursorAdapter._setDropDownViewResource10726 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.ResourceCursorAdapter._newView10727 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorAdapter._newDropDownView10728 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorAdapter._setViewResource10729 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "setViewResource", "(I)V");
			global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter10730 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V");
			global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter10731 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V");
		}
	}
}
