namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleAdapter.ViewBinder_))]
		public partial interface ViewBinder  : global::MonoJavaBridge.IJavaObject 
		{
			bool setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleAdapter.ViewBinder))]
		internal sealed partial class ViewBinder_ : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ViewBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.SimpleAdapter.ViewBinder.setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z", ref global::android.widget.SimpleAdapter.ViewBinder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static ViewBinder_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter$ViewBinder"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool ViewBinderDelegate(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2);

		internal partial class ViewBinderDelegateWrapper : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ViewBinderDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ViewBinderDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleAdapter.ViewBinderDelegateWrapper.staticClass, global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ViewBinderDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter_ViewBinderDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ViewBinderDelegateWrapper
		{
			private ViewBinderDelegate myDelegate;
			public bool setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator ViewBinderDelegateWrapper(ViewBinderDelegate d)
			{
				global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper ret = new global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleAdapter.staticClass, "getCount", "()I", ref global::android.widget.SimpleAdapter._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.SimpleAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SimpleAdapter.staticClass, "getItemId", "(I)J", ref global::android.widget.SimpleAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.SimpleAdapter._m3) as android.widget.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		public new int DropDownViewResource
		{
			set
			{
				setDropDownViewResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setDropDownViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, "setDropDownViewResource", "(I)V", ref global::android.widget.SimpleAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.SimpleAdapter.ViewBinder getViewBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.SimpleAdapter.ViewBinder>(this, global::android.widget.SimpleAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;", ref global::android.widget.SimpleAdapter._m7) as android.widget.SimpleAdapter.ViewBinder;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setViewBinder(android.widget.SimpleAdapter.ViewBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V", ref global::android.widget.SimpleAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setViewBinder(global::android.widget.SimpleAdapter.ViewBinderDelegate arg0)
		{
			setViewBinder((global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setViewImage(android.widget.ImageView arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;I)V", ref global::android.widget.SimpleAdapter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", ref global::android.widget.SimpleAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", ref global::android.widget.SimpleAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SimpleAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleAdapter._m12.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleAdapter._m12 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static SimpleAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
