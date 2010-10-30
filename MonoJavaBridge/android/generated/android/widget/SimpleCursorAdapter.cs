namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleCursorAdapter : android.widget.ResourceCursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleCursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleCursorAdapter.CursorToStringConverter_))]
		public partial interface CursorToStringConverter  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.lang.CharSequence convertToString(android.database.Cursor arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorAdapter.CursorToStringConverter))]
		internal sealed partial class CursorToStringConverter_ : java.lang.Object, CursorToStringConverter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CursorToStringConverter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.lang.CharSequence android.widget.SimpleCursorAdapter.CursorToStringConverter.convertToString(android.database.Cursor arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", ref global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
			}
			static CursorToStringConverter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter$CursorToStringConverter"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate java.lang.CharSequence CursorToStringConverterDelegate(android.database.Cursor arg0);

		internal partial class CursorToStringConverterDelegateWrapper : java.lang.Object, CursorToStringConverter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CursorToStringConverterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public CursorToStringConverterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper.staticClass, global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static CursorToStringConverterDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter_CursorToStringConverterDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class CursorToStringConverterDelegateWrapper
		{
			private CursorToStringConverterDelegate myDelegate;
			public java.lang.CharSequence convertToString(android.database.Cursor arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator CursorToStringConverterDelegateWrapper(CursorToStringConverterDelegate d)
			{
				global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper ret = new global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleCursorAdapter.ViewBinder_))]
		public partial interface ViewBinder  : global::MonoJavaBridge.IJavaObject 
		{
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorAdapter.ViewBinder))]
		internal sealed partial class ViewBinder_ : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ViewBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.SimpleCursorAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", ref global::android.widget.SimpleCursorAdapter.ViewBinder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static ViewBinder_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter$ViewBinder"));
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
				if (global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper.staticClass, global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ViewBinderDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter_ViewBinderDelegateWrapper"));
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
				global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper ret = new global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", ref global::android.widget.SimpleCursorAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void changeCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V", ref global::android.widget.SimpleCursorAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.CharSequence convertToString(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.SimpleCursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", ref global::android.widget.SimpleCursorAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.widget.SimpleCursorAdapter.ViewBinder getViewBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.SimpleCursorAdapter.ViewBinder>(this, global::android.widget.SimpleCursorAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;", ref global::android.widget.SimpleCursorAdapter._m3) as android.widget.SimpleCursorAdapter.ViewBinder;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V", ref global::android.widget.SimpleCursorAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setViewBinder(global::android.widget.SimpleCursorAdapter.ViewBinderDelegate arg0)
		{
			setViewBinder((global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", ref global::android.widget.SimpleCursorAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", ref global::android.widget.SimpleCursorAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int StringConversionColumn
		{
			get
			{
				return getStringConversionColumn();
			}
			set
			{
				setStringConversionColumn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getStringConversionColumn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "getStringConversionColumn", "()I", ref global::android.widget.SimpleCursorAdapter._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setStringConversionColumn(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "setStringConversionColumn", "(I)V", ref global::android.widget.SimpleCursorAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.widget.SimpleCursorAdapter.CursorToStringConverter getCursorToStringConverter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.SimpleCursorAdapter.CursorToStringConverter>(this, global::android.widget.SimpleCursorAdapter.staticClass, "getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;", ref global::android.widget.SimpleCursorAdapter._m9) as android.widget.SimpleCursorAdapter.CursorToStringConverter;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V", ref global::android.widget.SimpleCursorAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCursorToStringConverter(global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegate arg0)
		{
			setCursorToStringConverter((global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void changeCursorAndColumns(android.database.Cursor arg0, java.lang.String[] arg1, int[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, "changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V", ref global::android.widget.SimpleCursorAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SimpleCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, java.lang.String[] arg3, int[] arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleCursorAdapter._m12.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleCursorAdapter._m12 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static SimpleCursorAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
