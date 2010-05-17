namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SimpleCursorTreeAdapter : android.widget.ResourceCursorTreeAdapter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SimpleCursorTreeAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.SimpleCursorTreeAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SimpleCursorTreeAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ViewBinder 
		{ 
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindGroupView10052; 
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _bindGroupView10052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorTreeAdapter.staticClass, _bindGroupView10052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindChildView10053; 
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _bindChildView10053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorTreeAdapter.staticClass, _bindChildView10053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewBinder10054; 
		public virtual android.widget.SimpleCursorTreeAdapter.ViewBinder getViewBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorTreeAdapter.ViewBinder>(@__env, @__env.CallObjectMethodPtr(this, _getViewBinder10054)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorTreeAdapter.ViewBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleCursorTreeAdapter.staticClass, _getViewBinder10054)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewBinder10055; 
		public virtual void setViewBinder(android.widget.SimpleCursorTreeAdapter.ViewBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _setViewBinder10055, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorTreeAdapter.staticClass, _setViewBinder10055, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage10056; 
		protected virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _setViewImage10056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorTreeAdapter.staticClass, _setViewImage10056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewText10057; 
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _setViewText10057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorTreeAdapter.staticClass, _setViewText10057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorTreeAdapter10058; 
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, java.lang.String[] arg7, int[] arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, _SimpleCursorTreeAdapter10058, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorTreeAdapter10059; 
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, java.lang.String[] arg3, int[] arg4, int arg5, java.lang.String[] arg6, int[] arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, _SimpleCursorTreeAdapter10059, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorTreeAdapter10060; 
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, int arg7, java.lang.String[] arg8, int[] arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, _SimpleCursorTreeAdapter10060, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.SimpleCursorTreeAdapter.staticClass = @__class; 
			global::android.widget.SimpleCursorTreeAdapter._bindGroupView10052 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.SimpleCursorTreeAdapter._bindChildView10053 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.SimpleCursorTreeAdapter._getViewBinder10054 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;"); 
			global::android.widget.SimpleCursorTreeAdapter._setViewBinder10055 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V"); 
			global::android.widget.SimpleCursorTreeAdapter._setViewImage10056 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V"); 
			global::android.widget.SimpleCursorTreeAdapter._setViewText10057 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V"); 
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter10058 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[II[Ljava/lang/String;[I)V"); 
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter10059 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;I[Ljava/lang/String;[II[Ljava/lang/String;[I)V"); 
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter10060 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[III[Ljava/lang/String;[I)V"); 
		} 
	} 
} 
