namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleCursorAdapter : android.widget.ResourceCursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleCursorAdapter()
		{
			InitJNI();
		}
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
			static CursorToStringConverter_()
			{
				InitJNI();
			}
			internal CursorToStringConverter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _convertToString17758;
			 global::java.lang.CharSequence android.widget.SimpleCursorAdapter.CursorToStringConverter.convertToString(android.database.Cursor arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._convertToString17758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._convertToString17758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter$CursorToStringConverter"));
				global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._convertToString17758 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			}
		}

		public delegate java.lang.CharSequence CursorToStringConverterDelegate(android.database.Cursor arg0);

		internal partial class CursorToStringConverterDelegateWrapper : java.lang.Object, CursorToStringConverter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CursorToStringConverterDelegateWrapper()
			{
				InitJNI();
			}
			protected CursorToStringConverterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _CursorToStringConverterDelegateWrapper17759;
			public CursorToStringConverterDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper.staticClass, global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper._CursorToStringConverterDelegateWrapper17759);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter_CursorToStringConverterDelegateWrapper"));
				global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper._CursorToStringConverterDelegateWrapper17759 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper.staticClass, "<init>", "()V");
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
			static ViewBinder_()
			{
				InitJNI();
			}
			internal ViewBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setViewValue17760;
			 bool android.widget.SimpleCursorAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.ViewBinder_._setViewValue17760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass, global::android.widget.SimpleCursorAdapter.ViewBinder_._setViewValue17760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter$ViewBinder"));
				global::android.widget.SimpleCursorAdapter.ViewBinder_._setViewValue17760 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z");
			}
		}

		public delegate bool ViewBinderDelegate(android.view.View arg0, android.database.Cursor arg1, int arg2);

		internal partial class ViewBinderDelegateWrapper : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ViewBinderDelegateWrapper()
			{
				InitJNI();
			}
			protected ViewBinderDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ViewBinderDelegateWrapper17761;
			public ViewBinderDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper.staticClass, global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper._ViewBinderDelegateWrapper17761);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter_ViewBinderDelegateWrapper"));
				global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper._ViewBinderDelegateWrapper17761 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _bindView17762;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._bindView17762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._bindView17762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _changeCursor17763;
		public override void changeCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._changeCursor17763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._changeCursor17763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString17764;
		public override global::java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._convertToString17764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._convertToString17764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getViewBinder17765;
		public virtual global::android.widget.SimpleCursorAdapter.ViewBinder getViewBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.ViewBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._getViewBinder17765)) as android.widget.SimpleCursorAdapter.ViewBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.ViewBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getViewBinder17765)) as android.widget.SimpleCursorAdapter.ViewBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setViewBinder17766;
		public virtual void setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setViewBinder17766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewBinder17766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setViewBinder(global::android.widget.SimpleCursorAdapter.ViewBinderDelegate arg0)
		{
			setViewBinder((global::android.widget.SimpleCursorAdapter.ViewBinderDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage17767;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setViewImage17767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewImage17767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewText17768;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setViewText17768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewText17768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getStringConversionColumn17769;
		public virtual int getStringConversionColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._getStringConversionColumn17769);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getStringConversionColumn17769);
		}
		internal static global::MonoJavaBridge.MethodId _setStringConversionColumn17770;
		public virtual void setStringConversionColumn(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setStringConversionColumn17770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setStringConversionColumn17770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursorToStringConverter17771;
		public virtual global::android.widget.SimpleCursorAdapter.CursorToStringConverter getCursorToStringConverter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._getCursorToStringConverter17771)) as android.widget.SimpleCursorAdapter.CursorToStringConverter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getCursorToStringConverter17771)) as android.widget.SimpleCursorAdapter.CursorToStringConverter;
		}
		internal static global::MonoJavaBridge.MethodId _setCursorToStringConverter17772;
		public virtual void setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setCursorToStringConverter17772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setCursorToStringConverter17772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCursorToStringConverter(global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegate arg0)
		{
			setCursorToStringConverter((global::android.widget.SimpleCursorAdapter.CursorToStringConverterDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _changeCursorAndColumns17773;
		public virtual void changeCursorAndColumns(android.database.Cursor arg0, java.lang.String[] arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._changeCursorAndColumns17773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._changeCursorAndColumns17773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleCursorAdapter17774;
		public SimpleCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, java.lang.String[] arg3, int[] arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter17774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter"));
			global::android.widget.SimpleCursorAdapter._bindView17762 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.SimpleCursorAdapter._changeCursor17763 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.SimpleCursorAdapter._convertToString17764 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			global::android.widget.SimpleCursorAdapter._getViewBinder17765 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;");
			global::android.widget.SimpleCursorAdapter._setViewBinder17766 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V");
			global::android.widget.SimpleCursorAdapter._setViewImage17767 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorAdapter._setViewText17768 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorAdapter._getStringConversionColumn17769 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "getStringConversionColumn", "()I");
			global::android.widget.SimpleCursorAdapter._setStringConversionColumn17770 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setStringConversionColumn", "(I)V");
			global::android.widget.SimpleCursorAdapter._getCursorToStringConverter17771 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;");
			global::android.widget.SimpleCursorAdapter._setCursorToStringConverter17772 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V");
			global::android.widget.SimpleCursorAdapter._changeCursorAndColumns17773 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter17774 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V");
		}
	}
}
