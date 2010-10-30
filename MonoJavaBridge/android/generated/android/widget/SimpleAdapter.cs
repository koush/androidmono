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
			internal static global::MonoJavaBridge.MethodId _setViewValue17743;
			bool android.widget.SimpleAdapter.ViewBinder.setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SimpleAdapter.ViewBinder_._setViewValue17743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static ViewBinder_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter$ViewBinder"));
				global::android.widget.SimpleAdapter.ViewBinder_._setViewValue17743 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z");
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
			internal static global::MonoJavaBridge.MethodId _ViewBinderDelegateWrapper17744;
			public ViewBinderDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleAdapter.ViewBinderDelegateWrapper.staticClass, global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper._ViewBinderDelegateWrapper17744);
				Init(@__env, handle);
			}
			static ViewBinderDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter_ViewBinderDelegateWrapper"));
				global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper._ViewBinderDelegateWrapper17744 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getCount17745;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getCount17745);
		}
		internal static global::MonoJavaBridge.MethodId _getItem17746;
		public override global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getItem17746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId17747;
		public override long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getItemId17747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter17748;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getFilter17748)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _getView17749;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getView17749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView17750;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getDropDownView17750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		public new int DropDownViewResource
		{
			set
			{
				setDropDownViewResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource17751;
		public virtual void setDropDownViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setDropDownViewResource17751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewBinder17752;
		public virtual global::android.widget.SimpleAdapter.ViewBinder getViewBinder()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleAdapter.ViewBinder>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getViewBinder17752)) as android.widget.SimpleAdapter.ViewBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setViewBinder17753;
		public virtual void setViewBinder(android.widget.SimpleAdapter.ViewBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewBinder17753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setViewBinder(global::android.widget.SimpleAdapter.ViewBinderDelegate arg0)
		{
			setViewBinder((global::android.widget.SimpleAdapter.ViewBinderDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage17754;
		public virtual void setViewImage(android.widget.ImageView arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewImage17754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage17755;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewImage17755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewText17756;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewText17756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleAdapter17757;
		public SimpleAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._SimpleAdapter17757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static SimpleAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleAdapter"));
			global::android.widget.SimpleAdapter._getCount17745 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getCount", "()I");
			global::android.widget.SimpleAdapter._getItem17746 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.SimpleAdapter._getItemId17747 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.SimpleAdapter._getFilter17748 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.SimpleAdapter._getView17749 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleAdapter._getDropDownView17750 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleAdapter._setDropDownViewResource17751 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.SimpleAdapter._getViewBinder17752 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;");
			global::android.widget.SimpleAdapter._setViewBinder17753 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V");
			global::android.widget.SimpleAdapter._setViewImage17754 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;I)V");
			global::android.widget.SimpleAdapter._setViewImage17755 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleAdapter._setViewText17756 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleAdapter._SimpleAdapter17757 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
