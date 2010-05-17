namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ResourceCursorAdapter : android.widget.CursorAdapter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ResourceCursorAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ResourceCursorAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ResourceCursorAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource9950; 
		public virtual void setDropDownViewResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ResourceCursorAdapter)) 
				@__env.CallVoidMethod(this, _setDropDownViewResource9950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ResourceCursorAdapter.staticClass, _setDropDownViewResource9950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newView9951; 
		public override android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ResourceCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newView9951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ResourceCursorAdapter.staticClass, _newView9951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newDropDownView9952; 
		public override android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ResourceCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newDropDownView9952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ResourceCursorAdapter.staticClass, _newDropDownView9952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewResource9953; 
		public virtual void setViewResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ResourceCursorAdapter)) 
				@__env.CallVoidMethod(this, _setViewResource9953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ResourceCursorAdapter.staticClass, _setViewResource9953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ResourceCursorAdapter9954; 
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, _ResourceCursorAdapter9954, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ResourceCursorAdapter9955; 
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, _ResourceCursorAdapter9955, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ResourceCursorAdapter.staticClass = @__class; 
			global::android.widget.ResourceCursorAdapter._setDropDownViewResource9950 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "setDropDownViewResource", "(I)V"); 
			global::android.widget.ResourceCursorAdapter._newView9951 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ResourceCursorAdapter._newDropDownView9952 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ResourceCursorAdapter._setViewResource9953 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "setViewResource", "(I)V"); 
			global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter9954 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V"); 
			global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter9955 = @__env.GetMethodID(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V"); 
		} 
	} 
} 
