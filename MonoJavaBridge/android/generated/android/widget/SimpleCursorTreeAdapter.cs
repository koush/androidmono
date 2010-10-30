namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.SimpleCursorTreeAdapter_))]
	public abstract partial class SimpleCursorTreeAdapter : android.widget.ResourceCursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleCursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleCursorTreeAdapter.ViewBinder_))]
		public partial interface ViewBinder  : global::MonoJavaBridge.IJavaObject 
		{
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorTreeAdapter.ViewBinder))]
		internal sealed partial class ViewBinder_ : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ViewBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.SimpleCursorTreeAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleCursorTreeAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", ref global::android.widget.SimpleCursorTreeAdapter.ViewBinder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static ViewBinder_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorTreeAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter$ViewBinder"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool ViewBinderDelegate(android.view.View arg0, android.database.Cursor arg1, int arg2);

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
				if (global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper.staticClass, global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ViewBinderDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter_ViewBinderDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ViewBinderDelegateWrapper
		{
			private ViewBinderDelegate myDelegate;
			public bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator ViewBinderDelegateWrapper(ViewBinderDelegate d)
			{
				global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper ret = new global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.SimpleCursorTreeAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.SimpleCursorTreeAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.widget.SimpleCursorTreeAdapter.ViewBinder getViewBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.SimpleCursorTreeAdapter.ViewBinder>(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;", ref global::android.widget.SimpleCursorTreeAdapter._m2) as android.widget.SimpleCursorTreeAdapter.ViewBinder;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setViewBinder(android.widget.SimpleCursorTreeAdapter.ViewBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V", ref global::android.widget.SimpleCursorTreeAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setViewBinder(global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegate arg0)
		{
			setViewBinder((global::android.widget.SimpleCursorTreeAdapter.ViewBinderDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", ref global::android.widget.SimpleCursorTreeAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", ref global::android.widget.SimpleCursorTreeAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, java.lang.String[] arg7, int[] arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleCursorTreeAdapter._m6.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleCursorTreeAdapter._m6 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[II[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, java.lang.String[] arg3, int[] arg4, int arg5, java.lang.String[] arg6, int[] arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleCursorTreeAdapter._m7.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleCursorTreeAdapter._m7 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;I[Ljava/lang/String;[II[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, int arg7, java.lang.String[] arg8, int[] arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleCursorTreeAdapter._m8.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleCursorTreeAdapter._m8 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[III[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		static SimpleCursorTreeAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorTreeAdapter))]
	internal sealed partial class SimpleCursorTreeAdapter_ : android.widget.SimpleCursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SimpleCursorTreeAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.SimpleCursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", ref global::android.widget.SimpleCursorTreeAdapter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.Cursor;
		}
		static SimpleCursorTreeAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
