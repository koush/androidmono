namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SimpleAdapter : android.widget.BaseAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SimpleAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.SimpleAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.SimpleAdapter(@__env); 
			} 
		} 
		protected SimpleAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ViewBinder 
		{ 
			bool setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount10024; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return @__env.CallIntMethod(this, _getCount10024); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.SimpleAdapter.staticClass, _getCount10024); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem10025; 
		public override java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItem10025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleAdapter.staticClass, _getItem10025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10026; 
		public override long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return @__env.CallLongMethod(this, _getItemId10026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.SimpleAdapter.staticClass, _getItemId10026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10027; 
		public virtual android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter10027)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleAdapter.staticClass, _getFilter10027)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView10028; 
		public override android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView10028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleAdapter.staticClass, _getView10028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView10029; 
		public override android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getDropDownView10029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleAdapter.staticClass, _getDropDownView10029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource10030; 
		public virtual void setDropDownViewResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				@__env.CallVoidMethod(this, _setDropDownViewResource10030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleAdapter.staticClass, _setDropDownViewResource10030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewBinder10031; 
		public virtual android.widget.SimpleAdapter.ViewBinder getViewBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleAdapter.ViewBinder>(@__env, @__env.CallObjectMethodPtr(this, _getViewBinder10031)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleAdapter.ViewBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleAdapter.staticClass, _getViewBinder10031)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewBinder10032; 
		public virtual void setViewBinder(android.widget.SimpleAdapter.ViewBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				@__env.CallVoidMethod(this, _setViewBinder10032, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleAdapter.staticClass, _setViewBinder10032, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage10033; 
		public virtual void setViewImage(android.widget.ImageView arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				@__env.CallVoidMethod(this, _setViewImage10033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleAdapter.staticClass, _setViewImage10033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage10034; 
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				@__env.CallVoidMethod(this, _setViewImage10034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleAdapter.staticClass, _setViewImage10034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewText10035; 
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleAdapter)) 
				@__env.CallVoidMethod(this, _setViewText10035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleAdapter.staticClass, _setViewText10035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleAdapter10036; 
		public SimpleAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleAdapter.staticClass, _SimpleAdapter10036, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.SimpleAdapter.staticClass = @__class; 
			global::android.widget.SimpleAdapter._getCount10024 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.SimpleAdapter._getItem10025 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.SimpleAdapter._getItemId10026 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.SimpleAdapter._getFilter10027 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.SimpleAdapter._getView10028 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleAdapter._getDropDownView10029 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleAdapter._setDropDownViewResource10030 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setDropDownViewResource", "(I)V"); 
			global::android.widget.SimpleAdapter._getViewBinder10031 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;"); 
			global::android.widget.SimpleAdapter._setViewBinder10032 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V"); 
			global::android.widget.SimpleAdapter._setViewImage10033 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;I)V"); 
			global::android.widget.SimpleAdapter._setViewImage10034 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V"); 
			global::android.widget.SimpleAdapter._setViewText10035 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V"); 
			global::android.widget.SimpleAdapter._SimpleAdapter10036 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V"); 
		} 
	} 
} 
