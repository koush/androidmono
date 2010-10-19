namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleAdapter()
		{
			InitJNI();
		}
		protected SimpleAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleAdapter.ViewBinder_))]
		public interface ViewBinder  : global::MonoJavaBridge.IJavaObject 
		{
			bool setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleAdapter.ViewBinder))]
		public sealed partial class ViewBinder_ : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ViewBinder_()
			{
				InitJNI();
			}
			internal ViewBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setViewValue12451;
			 bool android.widget.SimpleAdapter.ViewBinder.setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SimpleAdapter.ViewBinder_._setViewValue12451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SimpleAdapter.ViewBinder_.staticClass, global::android.widget.SimpleAdapter.ViewBinder_._setViewValue12451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter$ViewBinder"));
				global::android.widget.SimpleAdapter.ViewBinder_._setViewValue12451 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z");
			}
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount12452;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getCount12452);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getCount12452);
		}
		internal static global::MonoJavaBridge.MethodId _getItem12453;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getItem12453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getItem12453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId12454;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getItemId12454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getItemId12454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter12455;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getFilter12455)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getFilter12455)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _getView12456;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getView12456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getView12456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView12457;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getDropDownView12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getDropDownView12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource12458;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter._setDropDownViewResource12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setDropDownViewResource12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewBinder12459;
		public virtual global::android.widget.SimpleAdapter.ViewBinder getViewBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleAdapter.ViewBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter._getViewBinder12459)) as android.widget.SimpleAdapter.ViewBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleAdapter.ViewBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getViewBinder12459)) as android.widget.SimpleAdapter.ViewBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setViewBinder12460;
		public virtual void setViewBinder(android.widget.SimpleAdapter.ViewBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter._setViewBinder12460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewBinder12460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage12461;
		public virtual void setViewImage(android.widget.ImageView arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter._setViewImage12461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewImage12461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage12462;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter._setViewImage12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewImage12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewText12463;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter._setViewText12463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewText12463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleAdapter12464;
		public SimpleAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._SimpleAdapter12464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter"));
			global::android.widget.SimpleAdapter._getCount12452 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getCount", "()I");
			global::android.widget.SimpleAdapter._getItem12453 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.SimpleAdapter._getItemId12454 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.SimpleAdapter._getFilter12455 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.SimpleAdapter._getView12456 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleAdapter._getDropDownView12457 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleAdapter._setDropDownViewResource12458 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.SimpleAdapter._getViewBinder12459 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;");
			global::android.widget.SimpleAdapter._setViewBinder12460 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V");
			global::android.widget.SimpleAdapter._setViewImage12461 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;I)V");
			global::android.widget.SimpleAdapter._setViewImage12462 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleAdapter._setViewText12463 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleAdapter._SimpleAdapter12464 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V");
		}
	}
}
