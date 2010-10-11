namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static View()
		{
			InitJNI();
		}
		protected View(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BaseSavedState()
			{
				InitJNI();
			}
			protected BaseSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState9101;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState9101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState9102;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState9102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR9103;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$BaseSavedState"));
				global::android.view.View.BaseSavedState._BaseSavedState9101 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.view.View.BaseSavedState._BaseSavedState9102 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MeasureSpec : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MeasureSpec()
			{
				InitJNI();
			}
			protected MeasureSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString9104;
			public static global::java.lang.String toString(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._toString9104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getSize9105;
			public static int getSize(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getSize9105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getMode9106;
			public static int getMode(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getMode9106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _makeMeasureSpec9107;
			public static int makeMeasureSpec(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._makeMeasureSpec9107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _MeasureSpec9108;
			public MeasureSpec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._MeasureSpec9108);
				Init(@__env, handle);
			}
			public static int UNSPECIFIED
			{
				get
				{
					return 0;
				}
			}
			public static int EXACTLY
			{
				get
				{
					return 1073741824;
				}
			}
			public static int AT_MOST
			{
				get
				{
					return -2147483648;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.MeasureSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$MeasureSpec"));
				global::android.view.View.MeasureSpec._toString9104 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;");
				global::android.view.View.MeasureSpec._getSize9105 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I");
				global::android.view.View.MeasureSpec._getMode9106 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I");
				global::android.view.View.MeasureSpec._makeMeasureSpec9107 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I");
				global::android.view.View.MeasureSpec._MeasureSpec9108 = @__env.GetMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnClickListener_))]
		public interface OnClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnClickListener))]
		public sealed partial class OnClickListener_ : java.lang.Object, OnClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnClickListener_()
			{
				InitJNI();
			}
			internal OnClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onClick9109;
			 void android.view.View.OnClickListener.onClick(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnClickListener_._onClick9109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnClickListener_.staticClass, global::android.view.View.OnClickListener_._onClick9109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnClickListener"));
				global::android.view.View.OnClickListener_._onClick9109 = @__env.GetMethodIDNoThrow(global::android.view.View.OnClickListener_.staticClass, "onClick", "(Landroid/view/View;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnCreateContextMenuListener_))]
		public interface OnCreateContextMenuListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnCreateContextMenuListener))]
		public sealed partial class OnCreateContextMenuListener_ : java.lang.Object, OnCreateContextMenuListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCreateContextMenuListener_()
			{
				InitJNI();
			}
			internal OnCreateContextMenuListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreateContextMenu9110;
			 void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu9110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnCreateContextMenuListener_.staticClass, global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu9110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnCreateContextMenuListener"));
				global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu9110 = @__env.GetMethodIDNoThrow(global::android.view.View.OnCreateContextMenuListener_.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnFocusChangeListener_))]
		public interface OnFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFocusChange(android.view.View arg0, bool arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnFocusChangeListener))]
		public sealed partial class OnFocusChangeListener_ : java.lang.Object, OnFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnFocusChangeListener_()
			{
				InitJNI();
			}
			internal OnFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onFocusChange9111;
			 void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnFocusChangeListener_._onFocusChange9111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnFocusChangeListener_.staticClass, global::android.view.View.OnFocusChangeListener_._onFocusChange9111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnFocusChangeListener"));
				global::android.view.View.OnFocusChangeListener_._onFocusChange9111 = @__env.GetMethodIDNoThrow(global::android.view.View.OnFocusChangeListener_.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnKeyListener_))]
		public interface OnKeyListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnKeyListener))]
		public sealed partial class OnKeyListener_ : java.lang.Object, OnKeyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnKeyListener_()
			{
				InitJNI();
			}
			internal OnKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKey9112;
			 bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnKeyListener_._onKey9112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnKeyListener_.staticClass, global::android.view.View.OnKeyListener_._onKey9112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnKeyListener"));
				global::android.view.View.OnKeyListener_._onKey9112 = @__env.GetMethodIDNoThrow(global::android.view.View.OnKeyListener_.staticClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnLongClickListener_))]
		public interface OnLongClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onLongClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnLongClickListener))]
		public sealed partial class OnLongClickListener_ : java.lang.Object, OnLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnLongClickListener_()
			{
				InitJNI();
			}
			internal OnLongClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLongClick9113;
			 bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnLongClickListener_._onLongClick9113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnLongClickListener_.staticClass, global::android.view.View.OnLongClickListener_._onLongClick9113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnLongClickListener"));
				global::android.view.View.OnLongClickListener_._onLongClick9113 = @__env.GetMethodIDNoThrow(global::android.view.View.OnLongClickListener_.staticClass, "onLongClick", "(Landroid/view/View;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnTouchListener_))]
		public interface OnTouchListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnTouchListener))]
		public sealed partial class OnTouchListener_ : java.lang.Object, OnTouchListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTouchListener_()
			{
				InitJNI();
			}
			internal OnTouchListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTouch9114;
			 bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnTouchListener_._onTouch9114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnTouchListener_.staticClass, global::android.view.View.OnTouchListener_._onTouch9114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnTouchListener"));
				global::android.view.View.OnTouchListener_._onTouch9114 = @__env.GetMethodIDNoThrow(global::android.view.View.OnTouchListener_.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources9115;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getResources9115)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getResources9115)) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getParent9116;
		public virtual global::android.view.ViewParent getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getParent9116)) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getParent9116)) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _getId9117;
		public virtual int getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getId9117);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getId9117);
		}
		internal static global::MonoJavaBridge.MethodId _getContext9118;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContext9118)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContext9118)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque9119;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isOpaque9119);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isOpaque9119);
		}
		internal static global::MonoJavaBridge.MethodId _getHandler9120;
		public virtual global::android.os.Handler getHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getHandler9120)) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHandler9120)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _inflate9121;
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._inflate9121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getTag9122;
		public virtual global::java.lang.Object getTag(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTag9122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTag9122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getTag9123;
		public virtual global::java.lang.Object getTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTag9123)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTag9123)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invalidate9124;
		public virtual void invalidate(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate9124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate9124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidate9125;
		public virtual void invalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate9125);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate9125);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate9126;
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate9126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate9126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _layout9127;
		public virtual void layout(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._layout9127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._layout9127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged9128;
		protected virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onConfigurationChanged9128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onConfigurationChanged9128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled9129;
		public virtual bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isEnabled9129);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isEnabled9129);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled9130;
		public virtual void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setEnabled9130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setEnabled9130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentDescription9131;
		public virtual global::java.lang.CharSequence getContentDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContentDescription9131)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContentDescription9131)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription9132;
		public virtual void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setContentDescription9132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setContentDescription9132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation9133;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getAnimation9133)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getAnimation9133)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _draw9134;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._draw9134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._draw9134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth9135;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWidth9135);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWidth9135);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight9136;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHeight9136);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHeight9136);
		}
		internal static global::MonoJavaBridge.MethodId _post9137;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._post9137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._post9137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed9138;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._postDelayed9138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postDelayed9138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks9139;
		public virtual bool removeCallbacks(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._removeCallbacks9139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._removeCallbacks9139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState9140;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onRestoreInstanceState9140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onRestoreInstanceState9140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState9141;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onSaveInstanceState9141)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSaveInstanceState9141)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _findViewById9142;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findViewById9142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findViewById9142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown9143;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyDown9143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyDown9143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress9144;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyLongPress9144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyLongPress9144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp9145;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyUp9145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyUp9145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple9146;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyMultiple9146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyMultiple9146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent9147;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onTouchEvent9147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onTouchEvent9147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent9148;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onTrackballEvent9148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onTrackballEvent9148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged9149;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onWindowFocusChanged9149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onWindowFocusChanged9149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus9150;
		public virtual bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasFocus9150);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasFocus9150);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow9151;
		protected virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAttachedToWindow9151);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAttachedToWindow9151);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow9152;
		protected virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDetachedFromWindow9152);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDetachedFromWindow9152);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus9153;
		public virtual bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasWindowFocus9153);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasWindowFocus9153);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent9154;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyEvent9154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEvent9154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent9155;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchTouchEvent9155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchTouchEvent9155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent9156;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchTrackballEvent9156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchTrackballEvent9156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent9157;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchPopulateAccessibilityEvent9157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchPopulateAccessibilityEvent9157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu9158;
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onCreateContextMenu9158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateContextMenu9158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable9159;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundDrawable9159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundDrawable9159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState9160;
		public virtual void saveHierarchyState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._saveHierarchyState9160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._saveHierarchyState9160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState9161;
		public virtual void restoreHierarchyState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._restoreHierarchyState9161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._restoreHierarchyState9161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initializeFadingEdge9162;
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._initializeFadingEdge9162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._initializeFadingEdge9162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalFadingEdgeLength9163;
		public virtual int getVerticalFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVerticalFadingEdgeLength9163);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVerticalFadingEdgeLength9163);
		}
		internal static global::MonoJavaBridge.MethodId _setFadingEdgeLength9164;
		public virtual void setFadingEdgeLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFadingEdgeLength9164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFadingEdgeLength9164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalFadingEdgeLength9165;
		public virtual int getHorizontalFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHorizontalFadingEdgeLength9165);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHorizontalFadingEdgeLength9165);
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalScrollbarWidth9166;
		public virtual int getVerticalScrollbarWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVerticalScrollbarWidth9166);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVerticalScrollbarWidth9166);
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalScrollbarHeight9167;
		protected virtual int getHorizontalScrollbarHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHorizontalScrollbarHeight9167);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHorizontalScrollbarHeight9167);
		}
		internal static global::MonoJavaBridge.MethodId _initializeScrollbars9168;
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._initializeScrollbars9168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._initializeScrollbars9168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnFocusChangeListener9169;
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnFocusChangeListener9169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnFocusChangeListener9169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnFocusChangeListener9170;
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.View.OnFocusChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getOnFocusChangeListener9170)) as android.view.View.OnFocusChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.View.OnFocusChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getOnFocusChangeListener9170)) as android.view.View.OnFocusChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener9171;
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnClickListener9171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnClickListener9171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnLongClickListener9172;
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnLongClickListener9172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnLongClickListener9172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCreateContextMenuListener9173;
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnCreateContextMenuListener9173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnCreateContextMenuListener9173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick9174;
		public virtual bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performClick9174);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performClick9174);
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick9175;
		public virtual bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performLongClick9175);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performLongClick9175);
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu9176;
		public virtual bool showContextMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._showContextMenu9176);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._showContextMenu9176);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener9177;
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnKeyListener9177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnKeyListener9177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnTouchListener9178;
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnTouchListener9178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnTouchListener9178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen9179;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestRectangleOnScreen9179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen9179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen9180;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestRectangleOnScreen9180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen9180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus9181;
		public virtual void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._clearFocus9181);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._clearFocus9181);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable9182;
		public virtual bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasFocusable9182);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasFocusable9182);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged9183;
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFocusChanged9183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFocusChanged9183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent9184;
		public virtual void sendAccessibilityEvent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._sendAccessibilityEvent9184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEvent9184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEventUnchecked9185;
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._sendAccessibilityEventUnchecked9185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEventUnchecked9185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocused9186;
		public virtual bool isFocused() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocused9186);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocused9186);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus9187;
		public virtual global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findFocus9187)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findFocus9187)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollContainer9188;
		public virtual void setScrollContainer(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollContainer9188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollContainer9188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheQuality9189;
		public virtual int getDrawingCacheQuality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getDrawingCacheQuality9189);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheQuality9189);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheQuality9190;
		public virtual void setDrawingCacheQuality(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheQuality9190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheQuality9190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeepScreenOn9191;
		public virtual bool getKeepScreenOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getKeepScreenOn9191);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getKeepScreenOn9191);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn9192;
		public virtual void setKeepScreenOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setKeepScreenOn9192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setKeepScreenOn9192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusLeftId9193;
		public virtual int getNextFocusLeftId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusLeftId9193);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusLeftId9193);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusLeftId9194;
		public virtual void setNextFocusLeftId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusLeftId9194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusLeftId9194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusRightId9195;
		public virtual int getNextFocusRightId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusRightId9195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusRightId9195);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusRightId9196;
		public virtual void setNextFocusRightId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusRightId9196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusRightId9196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusUpId9197;
		public virtual int getNextFocusUpId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusUpId9197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusUpId9197);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusUpId9198;
		public virtual void setNextFocusUpId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusUpId9198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusUpId9198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusDownId9199;
		public virtual int getNextFocusDownId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusDownId9199);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusDownId9199);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusDownId9200;
		public virtual void setNextFocusDownId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusDownId9200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusDownId9200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShown9201;
		public virtual bool isShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isShown9201);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isShown9201);
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows9202;
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._fitSystemWindows9202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._fitSystemWindows9202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVisibility9203;
		public virtual int getVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVisibility9203);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVisibility9203);
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility9204;
		public virtual void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVisibility9204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVisibility9204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable9205;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFocusable9205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFocusable9205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusableInTouchMode9206;
		public virtual void setFocusableInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFocusableInTouchMode9206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFocusableInTouchMode9206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoundEffectsEnabled9207;
		public virtual void setSoundEffectsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSoundEffectsEnabled9207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSoundEffectsEnabled9207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSoundEffectsEnabled9208;
		public virtual bool isSoundEffectsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSoundEffectsEnabled9208);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSoundEffectsEnabled9208);
		}
		internal static global::MonoJavaBridge.MethodId _setHapticFeedbackEnabled9209;
		public virtual void setHapticFeedbackEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHapticFeedbackEnabled9209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHapticFeedbackEnabled9209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHapticFeedbackEnabled9210;
		public virtual bool isHapticFeedbackEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHapticFeedbackEnabled9210);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHapticFeedbackEnabled9210);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotDraw9211;
		public virtual void setWillNotDraw(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setWillNotDraw9211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setWillNotDraw9211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotDraw9212;
		public virtual bool willNotDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._willNotDraw9212);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._willNotDraw9212);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotCacheDrawing9213;
		public virtual void setWillNotCacheDrawing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setWillNotCacheDrawing9213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setWillNotCacheDrawing9213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotCacheDrawing9214;
		public virtual bool willNotCacheDrawing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._willNotCacheDrawing9214);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._willNotCacheDrawing9214);
		}
		internal static global::MonoJavaBridge.MethodId _isClickable9215;
		public virtual bool isClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isClickable9215);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isClickable9215);
		}
		internal static global::MonoJavaBridge.MethodId _setClickable9216;
		public virtual void setClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setClickable9216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setClickable9216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongClickable9217;
		public virtual bool isLongClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isLongClickable9217);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isLongClickable9217);
		}
		internal static global::MonoJavaBridge.MethodId _setLongClickable9218;
		public virtual void setLongClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setLongClickable9218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setLongClickable9218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPressed9219;
		public virtual void setPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setPressed9219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setPressed9219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed9220;
		protected virtual void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSetPressed9220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSetPressed9220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPressed9221;
		public virtual bool isPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isPressed9221);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isPressed9221);
		}
		internal static global::MonoJavaBridge.MethodId _isSaveEnabled9222;
		public virtual bool isSaveEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSaveEnabled9222);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSaveEnabled9222);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveEnabled9223;
		public virtual void setSaveEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSaveEnabled9223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSaveEnabled9223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable9224;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocusable9224);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocusable9224);
		}
		internal static global::MonoJavaBridge.MethodId _isFocusableInTouchMode9225;
		public virtual bool isFocusableInTouchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocusableInTouchMode9225);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocusableInTouchMode9225);
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch9226;
		public virtual global::android.view.View focusSearch(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._focusSearch9226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._focusSearch9226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove9227;
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchUnhandledMove9227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchUnhandledMove9227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusables9228;
		public virtual global::java.util.ArrayList getFocusables(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getFocusables9228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getFocusables9228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables9229;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addFocusables9229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addFocusables9229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables9230;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addFocusables9230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addFocusables9230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTouchables9231;
		public virtual global::java.util.ArrayList getTouchables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTouchables9231)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTouchables9231)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables9232;
		public virtual void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addTouchables9232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addTouchables9232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9233;
		public virtual bool requestFocus(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus9233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus9233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9234;
		public virtual bool requestFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus9234);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus9234);
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9235;
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus9235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus9235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusFromTouch9236;
		public virtual bool requestFocusFromTouch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocusFromTouch9236);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocusFromTouch9236);
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach9237;
		public virtual void onStartTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onStartTemporaryDetach9237);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onStartTemporaryDetach9237);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach9238;
		public virtual void onFinishTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFinishTemporaryDetach9238);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFinishTemporaryDetach9238);
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState9239;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getKeyDispatcherState9239)) as android.view.KeyEvent.DispatcherState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getKeyDispatcherState9239)) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme9240;
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyEventPreIme9240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEventPreIme9240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent9241;
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyShortcutEvent9241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyShortcutEvent9241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged9242;
		public virtual void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchWindowFocusChanged9242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchWindowFocusChanged9242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged9243;
		protected virtual void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchVisibilityChanged9243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchVisibilityChanged9243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged9244;
		protected virtual void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onVisibilityChanged9244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onVisibilityChanged9244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint9245;
		public virtual void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchDisplayHint9245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchDisplayHint9245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint9246;
		protected virtual void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDisplayHint9246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDisplayHint9246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged9247;
		public virtual void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchWindowVisibilityChanged9247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchWindowVisibilityChanged9247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged9248;
		protected virtual void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onWindowVisibilityChanged9248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onWindowVisibilityChanged9248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibility9249;
		public virtual int getWindowVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWindowVisibility9249);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowVisibility9249);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibleDisplayFrame9250;
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getWindowVisibleDisplayFrame9250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowVisibleDisplayFrame9250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged9251;
		public virtual void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchConfigurationChanged9251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchConfigurationChanged9251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInTouchMode9252;
		public virtual bool isInTouchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isInTouchMode9252);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isInTouchMode9252);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme9253;
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyPreIme9253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyPreIme9253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut9254;
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyShortcut9254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyShortcut9254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor9255;
		public virtual bool onCheckIsTextEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onCheckIsTextEditor9255);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCheckIsTextEditor9255);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection9256;
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onCreateInputConnection9256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateInputConnection9256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy9257;
		public virtual bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._checkInputConnectionProxy9257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._checkInputConnectionProxy9257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu9258;
		public virtual void createContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._createContextMenu9258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._createContextMenu9258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo9259;
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContextMenuInfo9259)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContextMenuInfo9259)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress9260;
		public virtual void cancelLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._cancelLongPress9260);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._cancelLongPress9260);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchDelegate9261;
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTouchDelegate9261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTouchDelegate9261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTouchDelegate9262;
		public virtual global::android.view.TouchDelegate getTouchDelegate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTouchDelegate9262)) as android.view.TouchDelegate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTouchDelegate9262)) as android.view.TouchDelegate;
		}
		internal static global::MonoJavaBridge.MethodId _bringToFront9263;
		public virtual void bringToFront() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._bringToFront9263);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._bringToFront9263);
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged9264;
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onScrollChanged9264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onScrollChanged9264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged9265;
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onSizeChanged9265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSizeChanged9265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw9266;
		protected virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchDraw9266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchDraw9266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScrollX9267;
		public virtual int getScrollX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollX9267);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollX9267);
		}
		internal static global::MonoJavaBridge.MethodId _getScrollY9268;
		public virtual int getScrollY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollY9268);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollY9268);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingRect9269;
		public virtual void getDrawingRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getDrawingRect9269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingRect9269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredWidth9270;
		public virtual int getMeasuredWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getMeasuredWidth9270);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getMeasuredWidth9270);
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredHeight9271;
		public virtual int getMeasuredHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getMeasuredHeight9271);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getMeasuredHeight9271);
		}
		internal static global::MonoJavaBridge.MethodId _getTop9272;
		public virtual int getTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getTop9272);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTop9272);
		}
		internal static global::MonoJavaBridge.MethodId _getBottom9273;
		public virtual int getBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBottom9273);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottom9273);
		}
		internal static global::MonoJavaBridge.MethodId _getLeft9274;
		public virtual int getLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getLeft9274);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeft9274);
		}
		internal static global::MonoJavaBridge.MethodId _getRight9275;
		public virtual int getRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getRight9275);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRight9275);
		}
		internal static global::MonoJavaBridge.MethodId _getHitRect9276;
		public virtual void getHitRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getHitRect9276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHitRect9276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect9277;
		public virtual void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getFocusedRect9277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getFocusedRect9277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect9278;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getGlobalVisibleRect9278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect9278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect9279;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getGlobalVisibleRect9279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect9279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalVisibleRect9280;
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getLocalVisibleRect9280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocalVisibleRect9280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetTopAndBottom9281;
		public virtual void offsetTopAndBottom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._offsetTopAndBottom9281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._offsetTopAndBottom9281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLeftAndRight9282;
		public virtual void offsetLeftAndRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._offsetLeftAndRight9282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._offsetLeftAndRight9282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutParams9283;
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getLayoutParams9283)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLayoutParams9283)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams9284;
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setLayoutParams9284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setLayoutParams9284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo9285;
		public virtual void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scrollTo9285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scrollTo9285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollBy9286;
		public virtual void scrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scrollBy9286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scrollBy9286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars9287;
		protected virtual bool awakenScrollBars(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars9287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars9287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars9288;
		protected virtual bool awakenScrollBars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars9288);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars9288);
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars9289;
		protected virtual bool awakenScrollBars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars9289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars9289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate9290;
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidate9290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidate9290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate9291;
		public virtual void postInvalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidate9291);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidate9291);
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed9292;
		public virtual void postInvalidateDelayed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidateDelayed9292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed9292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed9293;
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidateDelayed9293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed9293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll9294;
		public virtual void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._computeScroll9294);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeScroll9294);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalFadingEdgeEnabled9295;
		public virtual bool isHorizontalFadingEdgeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHorizontalFadingEdgeEnabled9295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHorizontalFadingEdgeEnabled9295);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalFadingEdgeEnabled9296;
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHorizontalFadingEdgeEnabled9296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHorizontalFadingEdgeEnabled9296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalFadingEdgeEnabled9297;
		public virtual bool isVerticalFadingEdgeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isVerticalFadingEdgeEnabled9297);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isVerticalFadingEdgeEnabled9297);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalFadingEdgeEnabled9298;
		public virtual void setVerticalFadingEdgeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVerticalFadingEdgeEnabled9298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVerticalFadingEdgeEnabled9298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength9299;
		protected virtual float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getTopFadingEdgeStrength9299);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTopFadingEdgeStrength9299);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength9300;
		protected virtual float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getBottomFadingEdgeStrength9300);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottomFadingEdgeStrength9300);
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength9301;
		protected virtual float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getLeftFadingEdgeStrength9301);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeftFadingEdgeStrength9301);
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength9302;
		protected virtual float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getRightFadingEdgeStrength9302);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRightFadingEdgeStrength9302);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalScrollBarEnabled9303;
		public virtual bool isHorizontalScrollBarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHorizontalScrollBarEnabled9303);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHorizontalScrollBarEnabled9303);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollBarEnabled9304;
		public virtual void setHorizontalScrollBarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHorizontalScrollBarEnabled9304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHorizontalScrollBarEnabled9304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalScrollBarEnabled9305;
		public virtual bool isVerticalScrollBarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isVerticalScrollBarEnabled9305);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isVerticalScrollBarEnabled9305);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollBarEnabled9306;
		public virtual void setVerticalScrollBarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVerticalScrollBarEnabled9306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVerticalScrollBarEnabled9306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScrollbarFadingEnabled9307;
		public virtual void setScrollbarFadingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollbarFadingEnabled9307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollbarFadingEnabled9307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollbarFadingEnabled9308;
		public virtual bool isScrollbarFadingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isScrollbarFadingEnabled9308);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isScrollbarFadingEnabled9308);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle9309;
		public virtual void setScrollBarStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollBarStyle9309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollBarStyle9309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarStyle9310;
		public virtual int getScrollBarStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollBarStyle9310);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollBarStyle9310);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange9311;
		protected virtual int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollRange9311);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollRange9311);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset9312;
		protected virtual int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollOffset9312);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollOffset9312);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent9313;
		protected virtual int computeHorizontalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollExtent9313);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollExtent9313);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange9314;
		protected virtual int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollRange9314);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollRange9314);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset9315;
		protected virtual int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollOffset9315);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollOffset9315);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent9316;
		protected virtual int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollExtent9316);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollExtent9316);
		}
		internal static global::MonoJavaBridge.MethodId _onDrawScrollBars9317;
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDrawScrollBars9317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDrawScrollBars9317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw9318;
		protected virtual void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDraw9318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDraw9318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindowAttachCount9319;
		protected virtual int getWindowAttachCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWindowAttachCount9319);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowAttachCount9319);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowToken9320;
		public virtual global::android.os.IBinder getWindowToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getWindowToken9320)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowToken9320)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationWindowToken9321;
		public virtual global::android.os.IBinder getApplicationWindowToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getApplicationWindowToken9321)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getApplicationWindowToken9321)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState9322;
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSaveInstanceState9322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSaveInstanceState9322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState9323;
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchRestoreInstanceState9323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchRestoreInstanceState9323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingTime9324;
		public virtual long getDrawingTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.View._getDrawingTime9324);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingTime9324);
		}
		internal static global::MonoJavaBridge.MethodId _setDuplicateParentStateEnabled9325;
		public virtual void setDuplicateParentStateEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDuplicateParentStateEnabled9325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDuplicateParentStateEnabled9325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDuplicateParentStateEnabled9326;
		public virtual bool isDuplicateParentStateEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isDuplicateParentStateEnabled9326);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isDuplicateParentStateEnabled9326);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheEnabled9327;
		public virtual void setDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheEnabled9327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheEnabled9327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDrawingCacheEnabled9328;
		public virtual bool isDrawingCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isDrawingCacheEnabled9328);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isDrawingCacheEnabled9328);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache9329;
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawingCache9329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCache9329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache9330;
		public virtual global::android.graphics.Bitmap getDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawingCache9330)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCache9330)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _destroyDrawingCache9331;
		public virtual void destroyDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._destroyDrawingCache9331);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._destroyDrawingCache9331);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheBackgroundColor9332;
		public virtual void setDrawingCacheBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheBackgroundColor9332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheBackgroundColor9332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheBackgroundColor9333;
		public virtual int getDrawingCacheBackgroundColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getDrawingCacheBackgroundColor9333);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheBackgroundColor9333);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache9334;
		public virtual void buildDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._buildDrawingCache9334);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache9334);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache9335;
		public virtual void buildDrawingCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._buildDrawingCache9335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache9335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInEditMode9336;
		public virtual bool isInEditMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isInEditMode9336);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isInEditMode9336);
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired9337;
		protected virtual bool isPaddingOffsetRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isPaddingOffsetRequired9337);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isPaddingOffsetRequired9337);
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset9338;
		protected virtual int getLeftPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getLeftPaddingOffset9338);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeftPaddingOffset9338);
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset9339;
		protected virtual int getRightPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getRightPaddingOffset9339);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRightPaddingOffset9339);
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset9340;
		protected virtual int getTopPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getTopPaddingOffset9340);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTopPaddingOffset9340);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset9341;
		protected virtual int getBottomPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBottomPaddingOffset9341);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottomPaddingOffset9341);
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor9342;
		public virtual int getSolidColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSolidColor9342);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSolidColor9342);
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested9343;
		public virtual bool isLayoutRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isLayoutRequested9343);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isLayoutRequested9343);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout9344;
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onLayout9344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onLayout9344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate9345;
		protected virtual void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFinishInflate9345);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFinishInflate9345);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable9346;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidateDrawable9346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidateDrawable9346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable9347;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scheduleDrawable9347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scheduleDrawable9347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable9348;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._unscheduleDrawable9348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable9348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable9349;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._unscheduleDrawable9349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable9349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable9350;
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._verifyDrawable9350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._verifyDrawable9350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged9351;
		protected virtual void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._drawableStateChanged9351);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._drawableStateChanged9351);
		}
		internal static global::MonoJavaBridge.MethodId _refreshDrawableState9352;
		public virtual void refreshDrawableState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._refreshDrawableState9352);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._refreshDrawableState9352);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawableState9353;
		public virtual int[] getDrawableState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawableState9353)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawableState9353)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState9354;
		protected virtual int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onCreateDrawableState9354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateDrawableState9354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _mergeDrawableStates9355;
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._mergeDrawableStates9355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor9356;
		public virtual void setBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundColor9356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundColor9356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundResource9357;
		public virtual void setBackgroundResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundResource9357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundResource9357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBackground9358;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getBackground9358)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBackground9358)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPadding9359;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setPadding9359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setPadding9359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingTop9360;
		public virtual int getPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingTop9360);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingTop9360);
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingBottom9361;
		public virtual int getPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingBottom9361);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingBottom9361);
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingLeft9362;
		public virtual int getPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingLeft9362);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingLeft9362);
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingRight9363;
		public virtual int getPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingRight9363);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingRight9363);
		}
		internal static global::MonoJavaBridge.MethodId _setSelected9364;
		public virtual void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSelected9364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSelected9364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected9365;
		protected virtual void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSetSelected9365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSetSelected9365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSelected9366;
		public virtual bool isSelected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSelected9366);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSelected9366);
		}
		internal static global::MonoJavaBridge.MethodId _getViewTreeObserver9367;
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getViewTreeObserver9367)) as android.view.ViewTreeObserver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getViewTreeObserver9367)) as android.view.ViewTreeObserver;
		}
		internal static global::MonoJavaBridge.MethodId _getRootView9368;
		public virtual global::android.view.View getRootView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getRootView9368)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRootView9368)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getLocationOnScreen9369;
		public virtual void getLocationOnScreen(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getLocationOnScreen9369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocationOnScreen9369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocationInWindow9370;
		public virtual void getLocationInWindow(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getLocationInWindow9370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocationInWindow9370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTag9371;
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findViewWithTag9371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findViewWithTag9371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setId9372;
		public virtual void setId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setId9372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setId9372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTag9373;
		public virtual void setTag(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTag9373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTag9373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTag9374;
		public virtual void setTag(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTag9374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTag9374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline9375;
		public virtual int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBaseline9375);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBaseline9375);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout9376;
		public virtual void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._requestLayout9376);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestLayout9376);
		}
		internal static global::MonoJavaBridge.MethodId _forceLayout9377;
		public virtual void forceLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._forceLayout9377);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._forceLayout9377);
		}
		internal static global::MonoJavaBridge.MethodId _measure9378;
		public virtual void measure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._measure9378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._measure9378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure9379;
		protected virtual void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onMeasure9379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onMeasure9379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMeasuredDimension9380;
		protected virtual void setMeasuredDimension(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMeasuredDimension9380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMeasuredDimension9380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize9381;
		public static int resolveSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._resolveSize9381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSize9382;
		public static int getDefaultSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._getDefaultSize9382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumHeight9383;
		protected virtual int getSuggestedMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSuggestedMinimumHeight9383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumHeight9383);
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumWidth9384;
		protected virtual int getSuggestedMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSuggestedMinimumWidth9384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumWidth9384);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeight9385;
		public virtual void setMinimumHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMinimumHeight9385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMinimumHeight9385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumWidth9386;
		public virtual void setMinimumWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMinimumWidth9386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMinimumWidth9386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startAnimation9387;
		public virtual void startAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._startAnimation9387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._startAnimation9387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAnimation9388;
		public virtual void clearAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._clearAnimation9388);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._clearAnimation9388);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation9389;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setAnimation9389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setAnimation9389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart9390;
		protected virtual void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAnimationStart9390);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAnimationStart9390);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd9391;
		protected virtual void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAnimationEnd9391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAnimationEnd9391);
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha9392;
		protected virtual bool onSetAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onSetAlpha9392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSetAlpha9392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect9393;
		public virtual void playSoundEffect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._playSoundEffect9393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._playSoundEffect9393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback9394;
		public virtual bool performHapticFeedback(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performHapticFeedback9394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback9394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback9395;
		public virtual bool performHapticFeedback(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performHapticFeedback9395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback9395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _View9396;
		public View(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View9396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View9397;
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View9397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View9398;
		public View(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View9398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int NO_ID
		{
			get
			{
				return -1;
			}
		}
		public static int VISIBLE
		{
			get
			{
				return 0;
			}
		}
		public static int INVISIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int GONE
		{
			get
			{
				return 8;
			}
		}
		public static int DRAWING_CACHE_QUALITY_LOW
		{
			get
			{
				return 524288;
			}
		}
		public static int DRAWING_CACHE_QUALITY_HIGH
		{
			get
			{
				return 1048576;
			}
		}
		public static int DRAWING_CACHE_QUALITY_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_OVERLAY
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_INSET
		{
			get
			{
				return 16777216;
			}
		}
		public static int SCROLLBARS_OUTSIDE_OVERLAY
		{
			get
			{
				return 33554432;
			}
		}
		public static int SCROLLBARS_OUTSIDE_INSET
		{
			get
			{
				return 50331648;
			}
		}
		public static int KEEP_SCREEN_ON
		{
			get
			{
				return 67108864;
			}
		}
		public static int SOUND_EFFECTS_ENABLED
		{
			get
			{
				return 134217728;
			}
		}
		public static int HAPTIC_FEEDBACK_ENABLED
		{
			get
			{
				return 268435456;
			}
		}
		public static int FOCUSABLES_ALL
		{
			get
			{
				return 0;
			}
		}
		public static int FOCUSABLES_TOUCH_MODE
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_BACKWARD
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_FORWARD
		{
			get
			{
				return 2;
			}
		}
		public static int FOCUS_LEFT
		{
			get
			{
				return 17;
			}
		}
		public static int FOCUS_UP
		{
			get
			{
				return 33;
			}
		}
		public static int FOCUS_RIGHT
		{
			get
			{
				return 66;
			}
		}
		public static int FOCUS_DOWN
		{
			get
			{
				return 130;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.View.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View"));
			global::android.view.View._getResources9115 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.view.View._getParent9116 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;");
			global::android.view.View._getId9117 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getId", "()I");
			global::android.view.View._getContext9118 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.View._isOpaque9119 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isOpaque", "()Z");
			global::android.view.View._getHandler9120 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;");
			global::android.view.View._inflate9121 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.View._getTag9122 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;");
			global::android.view.View._getTag9123 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;");
			global::android.view.View._invalidate9124 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V");
			global::android.view.View._invalidate9125 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "()V");
			global::android.view.View._invalidate9126 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "(IIII)V");
			global::android.view.View._layout9127 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "layout", "(IIII)V");
			global::android.view.View._onConfigurationChanged9128 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isEnabled9129 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isEnabled", "()Z");
			global::android.view.View._setEnabled9130 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setEnabled", "(Z)V");
			global::android.view.View._getContentDescription9131 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.View._setContentDescription9132 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.View._getAnimation9133 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.View._draw9134 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWidth9135 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWidth", "()I");
			global::android.view.View._getHeight9136 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHeight", "()I");
			global::android.view.View._post9137 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._postDelayed9138 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.view.View._removeCallbacks9139 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._onRestoreInstanceState9140 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.view.View._onSaveInstanceState9141 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.view.View._findViewById9142 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.View._onKeyDown9143 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyLongPress9144 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyUp9145 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyMultiple9146 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.view.View._onTouchEvent9147 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onTrackballEvent9148 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onWindowFocusChanged9149 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.view.View._hasFocus9150 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasFocus", "()Z");
			global::android.view.View._onAttachedToWindow9151 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAttachedToWindow", "()V");
			global::android.view.View._onDetachedFromWindow9152 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.View._hasWindowFocus9153 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasWindowFocus", "()Z");
			global::android.view.View._dispatchKeyEvent9154 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchTouchEvent9155 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchTrackballEvent9156 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchPopulateAccessibilityEvent9157 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.View._onCreateContextMenu9158 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._setBackgroundDrawable9159 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._saveHierarchyState9160 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._restoreHierarchyState9161 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._initializeFadingEdge9162 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._getVerticalFadingEdgeLength9163 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I");
			global::android.view.View._setFadingEdgeLength9164 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V");
			global::android.view.View._getHorizontalFadingEdgeLength9165 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I");
			global::android.view.View._getVerticalScrollbarWidth9166 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I");
			global::android.view.View._getHorizontalScrollbarHeight9167 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I");
			global::android.view.View._initializeScrollbars9168 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._setOnFocusChangeListener9169 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V");
			global::android.view.View._getOnFocusChangeListener9170 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;");
			global::android.view.View._setOnClickListener9171 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.view.View._setOnLongClickListener9172 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V");
			global::android.view.View._setOnCreateContextMenuListener9173 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V");
			global::android.view.View._performClick9174 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performClick", "()Z");
			global::android.view.View._performLongClick9175 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performLongClick", "()Z");
			global::android.view.View._showContextMenu9176 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "showContextMenu", "()Z");
			global::android.view.View._setOnKeyListener9177 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V");
			global::android.view.View._setOnTouchListener9178 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V");
			global::android.view.View._requestRectangleOnScreen9179 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._requestRectangleOnScreen9180 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z");
			global::android.view.View._clearFocus9181 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "clearFocus", "()V");
			global::android.view.View._hasFocusable9182 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasFocusable", "()Z");
			global::android.view.View._onFocusChanged9183 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.view.View._sendAccessibilityEvent9184 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V");
			global::android.view.View._sendAccessibilityEventUnchecked9185 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.View._isFocused9186 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocused", "()Z");
			global::android.view.View._findFocus9187 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.View._setScrollContainer9188 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollContainer", "(Z)V");
			global::android.view.View._getDrawingCacheQuality9189 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCacheQuality", "()I");
			global::android.view.View._setDrawingCacheQuality9190 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V");
			global::android.view.View._getKeepScreenOn9191 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getKeepScreenOn", "()Z");
			global::android.view.View._setKeepScreenOn9192 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V");
			global::android.view.View._getNextFocusLeftId9193 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusLeftId", "()I");
			global::android.view.View._setNextFocusLeftId9194 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V");
			global::android.view.View._getNextFocusRightId9195 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusRightId", "()I");
			global::android.view.View._setNextFocusRightId9196 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusRightId", "(I)V");
			global::android.view.View._getNextFocusUpId9197 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusUpId", "()I");
			global::android.view.View._setNextFocusUpId9198 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusUpId", "(I)V");
			global::android.view.View._getNextFocusDownId9199 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusDownId", "()I");
			global::android.view.View._setNextFocusDownId9200 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusDownId", "(I)V");
			global::android.view.View._isShown9201 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isShown", "()Z");
			global::android.view.View._fitSystemWindows9202 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getVisibility9203 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVisibility", "()I");
			global::android.view.View._setVisibility9204 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVisibility", "(I)V");
			global::android.view.View._setFocusable9205 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFocusable", "(Z)V");
			global::android.view.View._setFocusableInTouchMode9206 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.view.View._setSoundEffectsEnabled9207 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V");
			global::android.view.View._isSoundEffectsEnabled9208 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z");
			global::android.view.View._setHapticFeedbackEnabled9209 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V");
			global::android.view.View._isHapticFeedbackEnabled9210 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z");
			global::android.view.View._setWillNotDraw9211 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setWillNotDraw", "(Z)V");
			global::android.view.View._willNotDraw9212 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "willNotDraw", "()Z");
			global::android.view.View._setWillNotCacheDrawing9213 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V");
			global::android.view.View._willNotCacheDrawing9214 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "willNotCacheDrawing", "()Z");
			global::android.view.View._isClickable9215 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isClickable", "()Z");
			global::android.view.View._setClickable9216 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setClickable", "(Z)V");
			global::android.view.View._isLongClickable9217 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isLongClickable", "()Z");
			global::android.view.View._setLongClickable9218 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setLongClickable", "(Z)V");
			global::android.view.View._setPressed9219 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setPressed", "(Z)V");
			global::android.view.View._dispatchSetPressed9220 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.View._isPressed9221 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isPressed", "()Z");
			global::android.view.View._isSaveEnabled9222 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSaveEnabled", "()Z");
			global::android.view.View._setSaveEnabled9223 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSaveEnabled", "(Z)V");
			global::android.view.View._isFocusable9224 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocusable", "()Z");
			global::android.view.View._isFocusableInTouchMode9225 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z");
			global::android.view.View._focusSearch9226 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;");
			global::android.view.View._dispatchUnhandledMove9227 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.View._getFocusables9228 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;");
			global::android.view.View._addFocusables9229 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.View._addFocusables9230 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.View._getTouchables9231 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;");
			global::android.view.View._addTouchables9232 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.View._requestFocus9233 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "(I)Z");
			global::android.view.View._requestFocus9234 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "()Z");
			global::android.view.View._requestFocus9235 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.View._requestFocusFromTouch9236 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocusFromTouch", "()Z");
			global::android.view.View._onStartTemporaryDetach9237 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onStartTemporaryDetach", "()V");
			global::android.view.View._onFinishTemporaryDetach9238 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.view.View._getKeyDispatcherState9239 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.view.View._dispatchKeyEventPreIme9240 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchKeyShortcutEvent9241 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchWindowFocusChanged9242 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.View._dispatchVisibilityChanged9243 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._onVisibilityChanged9244 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._dispatchDisplayHint9245 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.View._onDisplayHint9246 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDisplayHint", "(I)V");
			global::android.view.View._dispatchWindowVisibilityChanged9247 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.View._onWindowVisibilityChanged9248 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.View._getWindowVisibility9249 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowVisibility", "()I");
			global::android.view.View._getWindowVisibleDisplayFrame9250 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V");
			global::android.view.View._dispatchConfigurationChanged9251 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isInTouchMode9252 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isInTouchMode", "()Z");
			global::android.view.View._onKeyPreIme9253 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyShortcut9254 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onCheckIsTextEditor9255 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.view.View._onCreateInputConnection9256 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.view.View._checkInputConnectionProxy9257 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.view.View._createContextMenu9258 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._getContextMenuInfo9259 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.view.View._cancelLongPress9260 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "cancelLongPress", "()V");
			global::android.view.View._setTouchDelegate9261 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V");
			global::android.view.View._getTouchDelegate9262 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;");
			global::android.view.View._bringToFront9263 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "bringToFront", "()V");
			global::android.view.View._onScrollChanged9264 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onScrollChanged", "(IIII)V");
			global::android.view.View._onSizeChanged9265 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.View._dispatchDraw9266 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getScrollX9267 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollX", "()I");
			global::android.view.View._getScrollY9268 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollY", "()I");
			global::android.view.View._getDrawingRect9269 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getMeasuredWidth9270 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getMeasuredWidth", "()I");
			global::android.view.View._getMeasuredHeight9271 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getMeasuredHeight", "()I");
			global::android.view.View._getTop9272 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTop", "()I");
			global::android.view.View._getBottom9273 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottom", "()I");
			global::android.view.View._getLeft9274 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeft", "()I");
			global::android.view.View._getRight9275 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRight", "()I");
			global::android.view.View._getHitRect9276 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getFocusedRect9277 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getGlobalVisibleRect9278 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.View._getGlobalVisibleRect9279 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getLocalVisibleRect9280 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._offsetTopAndBottom9281 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V");
			global::android.view.View._offsetLeftAndRight9282 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V");
			global::android.view.View._getLayoutParams9283 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.View._setLayoutParams9284 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.View._scrollTo9285 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scrollTo", "(II)V");
			global::android.view.View._scrollBy9286 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scrollBy", "(II)V");
			global::android.view.View._awakenScrollBars9287 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z");
			global::android.view.View._awakenScrollBars9288 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "()Z");
			global::android.view.View._awakenScrollBars9289 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "(I)Z");
			global::android.view.View._postInvalidate9290 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidate", "(IIII)V");
			global::android.view.View._postInvalidate9291 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidate", "()V");
			global::android.view.View._postInvalidateDelayed9292 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V");
			global::android.view.View._postInvalidateDelayed9293 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V");
			global::android.view.View._computeScroll9294 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeScroll", "()V");
			global::android.view.View._isHorizontalFadingEdgeEnabled9295 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z");
			global::android.view.View._setHorizontalFadingEdgeEnabled9296 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._isVerticalFadingEdgeEnabled9297 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z");
			global::android.view.View._setVerticalFadingEdgeEnabled9298 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._getTopFadingEdgeStrength9299 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.view.View._getBottomFadingEdgeStrength9300 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.view.View._getLeftFadingEdgeStrength9301 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.view.View._getRightFadingEdgeStrength9302 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.view.View._isHorizontalScrollBarEnabled9303 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z");
			global::android.view.View._setHorizontalScrollBarEnabled9304 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V");
			global::android.view.View._isVerticalScrollBarEnabled9305 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z");
			global::android.view.View._setVerticalScrollBarEnabled9306 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V");
			global::android.view.View._setScrollbarFadingEnabled9307 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V");
			global::android.view.View._isScrollbarFadingEnabled9308 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z");
			global::android.view.View._setScrollBarStyle9309 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollBarStyle", "(I)V");
			global::android.view.View._getScrollBarStyle9310 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollBarStyle", "()I");
			global::android.view.View._computeHorizontalScrollRange9311 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.view.View._computeHorizontalScrollOffset9312 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.view.View._computeHorizontalScrollExtent9313 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.view.View._computeVerticalScrollRange9314 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollRange", "()I");
			global::android.view.View._computeVerticalScrollOffset9315 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.view.View._computeVerticalScrollExtent9316 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.view.View._onDrawScrollBars9317 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._onDraw9318 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWindowAttachCount9319 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowAttachCount", "()I");
			global::android.view.View._getWindowToken9320 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._getApplicationWindowToken9321 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._dispatchSaveInstanceState9322 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._dispatchRestoreInstanceState9323 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._getDrawingTime9324 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingTime", "()J");
			global::android.view.View._setDuplicateParentStateEnabled9325 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V");
			global::android.view.View._isDuplicateParentStateEnabled9326 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z");
			global::android.view.View._setDrawingCacheEnabled9327 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V");
			global::android.view.View._isDrawingCacheEnabled9328 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z");
			global::android.view.View._getDrawingCache9329 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;");
			global::android.view.View._getDrawingCache9330 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;");
			global::android.view.View._destroyDrawingCache9331 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "destroyDrawingCache", "()V");
			global::android.view.View._setDrawingCacheBackgroundColor9332 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V");
			global::android.view.View._getDrawingCacheBackgroundColor9333 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I");
			global::android.view.View._buildDrawingCache9334 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "buildDrawingCache", "()V");
			global::android.view.View._buildDrawingCache9335 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "buildDrawingCache", "(Z)V");
			global::android.view.View._isInEditMode9336 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isInEditMode", "()Z");
			global::android.view.View._isPaddingOffsetRequired9337 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.view.View._getLeftPaddingOffset9338 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeftPaddingOffset", "()I");
			global::android.view.View._getRightPaddingOffset9339 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRightPaddingOffset", "()I");
			global::android.view.View._getTopPaddingOffset9340 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTopPaddingOffset", "()I");
			global::android.view.View._getBottomPaddingOffset9341 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottomPaddingOffset", "()I");
			global::android.view.View._getSolidColor9342 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSolidColor", "()I");
			global::android.view.View._isLayoutRequested9343 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isLayoutRequested", "()Z");
			global::android.view.View._onLayout9344 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.View._onFinishInflate9345 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFinishInflate", "()V");
			global::android.view.View._invalidateDrawable9346 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._scheduleDrawable9347 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.view.View._unscheduleDrawable9348 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.view.View._unscheduleDrawable9349 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._verifyDrawable9350 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.view.View._drawableStateChanged9351 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "drawableStateChanged", "()V");
			global::android.view.View._refreshDrawableState9352 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "refreshDrawableState", "()V");
			global::android.view.View._getDrawableState9353 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawableState", "()[I");
			global::android.view.View._onCreateDrawableState9354 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.View._mergeDrawableStates9355 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I");
			global::android.view.View._setBackgroundColor9356 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundColor", "(I)V");
			global::android.view.View._setBackgroundResource9357 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundResource", "(I)V");
			global::android.view.View._getBackground9358 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.View._setPadding9359 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setPadding", "(IIII)V");
			global::android.view.View._getPaddingTop9360 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingTop", "()I");
			global::android.view.View._getPaddingBottom9361 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingBottom", "()I");
			global::android.view.View._getPaddingLeft9362 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingLeft", "()I");
			global::android.view.View._getPaddingRight9363 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingRight", "()I");
			global::android.view.View._setSelected9364 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSelected", "(Z)V");
			global::android.view.View._dispatchSetSelected9365 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.View._isSelected9366 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSelected", "()Z");
			global::android.view.View._getViewTreeObserver9367 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;");
			global::android.view.View._getRootView9368 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;");
			global::android.view.View._getLocationOnScreen9369 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocationOnScreen", "([I)V");
			global::android.view.View._getLocationInWindow9370 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocationInWindow", "([I)V");
			global::android.view.View._findViewWithTag9371 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.view.View._setId9372 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setId", "(I)V");
			global::android.view.View._setTag9373 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V");
			global::android.view.View._setTag9374 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V");
			global::android.view.View._getBaseline9375 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBaseline", "()I");
			global::android.view.View._requestLayout9376 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestLayout", "()V");
			global::android.view.View._forceLayout9377 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "forceLayout", "()V");
			global::android.view.View._measure9378 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "measure", "(II)V");
			global::android.view.View._onMeasure9379 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onMeasure", "(II)V");
			global::android.view.View._setMeasuredDimension9380 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMeasuredDimension", "(II)V");
			global::android.view.View._resolveSize9381 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "resolveSize", "(II)I");
			global::android.view.View._getDefaultSize9382 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "getDefaultSize", "(II)I");
			global::android.view.View._getSuggestedMinimumHeight9383 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I");
			global::android.view.View._getSuggestedMinimumWidth9384 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I");
			global::android.view.View._setMinimumHeight9385 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMinimumHeight", "(I)V");
			global::android.view.View._setMinimumWidth9386 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMinimumWidth", "(I)V");
			global::android.view.View._startAnimation9387 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._clearAnimation9388 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "clearAnimation", "()V");
			global::android.view.View._setAnimation9389 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._onAnimationStart9390 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAnimationStart", "()V");
			global::android.view.View._onAnimationEnd9391 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAnimationEnd", "()V");
			global::android.view.View._onSetAlpha9392 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSetAlpha", "(I)Z");
			global::android.view.View._playSoundEffect9393 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "playSoundEffect", "(I)V");
			global::android.view.View._performHapticFeedback9394 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performHapticFeedback", "(I)Z");
			global::android.view.View._performHapticFeedback9395 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performHapticFeedback", "(II)Z");
			global::android.view.View._View9396 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.View._View9397 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.View._View9398 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
