namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{
		internal static global::java.lang.Class staticClass;
		static View()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.View(@__env);
			}
		}
		protected View(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::java.lang.Class staticClass;
			static BaseSavedState()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.BaseSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.BaseSavedState(@__env);
				}
			}
			protected BaseSavedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState8792;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState8792, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState8793;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState8793, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR8794;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.BaseSavedState.staticClass = @__class;
				global::android.view.View.BaseSavedState._BaseSavedState8792 = @__env.GetMethodID(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.view.View.BaseSavedState._BaseSavedState8793 = @__env.GetMethodID(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class MeasureSpec : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static MeasureSpec()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.MeasureSpec), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.MeasureSpec(@__env);
				}
			}
			protected MeasureSpec(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString8795;
			public static global::java.lang.String toString(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._toString8795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSize8796;
			public static int getSize(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getSize8796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getMode8797;
			public static int getMode(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getMode8797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _makeMeasureSpec8798;
			public static int makeMeasureSpec(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._makeMeasureSpec8798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MeasureSpec8799;
			public MeasureSpec()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._MeasureSpec8799, this);
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.MeasureSpec.staticClass = @__class;
				global::android.view.View.MeasureSpec._toString8795 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;");
				global::android.view.View.MeasureSpec._getSize8796 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I");
				global::android.view.View.MeasureSpec._getMode8797 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I");
				global::android.view.View.MeasureSpec._makeMeasureSpec8798 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I");
				global::android.view.View.MeasureSpec._MeasureSpec8799 = @__env.GetMethodID(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnClickListener 
		{
			void onClick(android.view.View arg0);
		}

		public partial class OnClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnClickListener : java.lang.Object, OnClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.__OnClickListener(@__env);
				}
			}
			internal __OnClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onClick8800;
			 void android.view.View.OnClickListener.onClick(android.view.View arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.View.__OnClickListener._onClick8800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.View.__OnClickListener.staticClass, global::android.view.View.__OnClickListener._onClick8800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.__OnClickListener.staticClass = @__class;
				global::android.view.View.__OnClickListener._onClick8800 = @__env.GetMethodID(global::android.view.View.__OnClickListener.staticClass, "android.view.View.OnClickListener.onClick", "(Landroid/view/View;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnCreateContextMenuListener 
		{
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);
		}

		public partial class OnCreateContextMenuListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnCreateContextMenuListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnCreateContextMenuListener : java.lang.Object, OnCreateContextMenuListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnCreateContextMenuListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnCreateContextMenuListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.__OnCreateContextMenuListener(@__env);
				}
			}
			internal __OnCreateContextMenuListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu8801;
			 void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.View.__OnCreateContextMenuListener._onCreateContextMenu8801, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.View.__OnCreateContextMenuListener.staticClass, global::android.view.View.__OnCreateContextMenuListener._onCreateContextMenu8801, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.__OnCreateContextMenuListener.staticClass = @__class;
				global::android.view.View.__OnCreateContextMenuListener._onCreateContextMenu8801 = @__env.GetMethodID(global::android.view.View.__OnCreateContextMenuListener.staticClass, "android.view.View.OnCreateContextMenuListener.onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnFocusChangeListener 
		{
			void onFocusChange(android.view.View arg0, bool arg1);
		}

		public partial class OnFocusChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnFocusChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnFocusChangeListener : java.lang.Object, OnFocusChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnFocusChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnFocusChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.__OnFocusChangeListener(@__env);
				}
			}
			internal __OnFocusChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onFocusChange8802;
			 void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.View.__OnFocusChangeListener._onFocusChange8802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.View.__OnFocusChangeListener.staticClass, global::android.view.View.__OnFocusChangeListener._onFocusChange8802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.__OnFocusChangeListener.staticClass = @__class;
				global::android.view.View.__OnFocusChangeListener._onFocusChange8802 = @__env.GetMethodID(global::android.view.View.__OnFocusChangeListener.staticClass, "android.view.View.OnFocusChangeListener.onFocusChange", "(Landroid/view/View;Z)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnKeyListener 
		{
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2);
		}

		public partial class OnKeyListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnKeyListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnKeyListener : java.lang.Object, OnKeyListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnKeyListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.__OnKeyListener(@__env);
				}
			}
			internal __OnKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onKey8803;
			 bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.View.__OnKeyListener._onKey8803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.__OnKeyListener.staticClass, global::android.view.View.__OnKeyListener._onKey8803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.__OnKeyListener.staticClass = @__class;
				global::android.view.View.__OnKeyListener._onKey8803 = @__env.GetMethodID(global::android.view.View.__OnKeyListener.staticClass, "android.view.View.OnKeyListener.onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnLongClickListener 
		{
			bool onLongClick(android.view.View arg0);
		}

		public partial class OnLongClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnLongClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnLongClickListener : java.lang.Object, OnLongClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnLongClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnLongClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.__OnLongClickListener(@__env);
				}
			}
			internal __OnLongClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onLongClick8804;
			 bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.View.__OnLongClickListener._onLongClick8804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.__OnLongClickListener.staticClass, global::android.view.View.__OnLongClickListener._onLongClick8804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.__OnLongClickListener.staticClass = @__class;
				global::android.view.View.__OnLongClickListener._onLongClick8804 = @__env.GetMethodID(global::android.view.View.__OnLongClickListener.staticClass, "android.view.View.OnLongClickListener.onLongClick", "(Landroid/view/View;)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnTouchListener 
		{
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1);
		}

		public partial class OnTouchListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnTouchListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnTouchListener : java.lang.Object, OnTouchListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnTouchListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnTouchListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.View.__OnTouchListener(@__env);
				}
			}
			internal __OnTouchListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onTouch8805;
			 bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.View.__OnTouchListener._onTouch8805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.__OnTouchListener.staticClass, global::android.view.View.__OnTouchListener._onTouch8805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.View.__OnTouchListener.staticClass = @__class;
				global::android.view.View.__OnTouchListener._onTouch8805 = @__env.GetMethodID(global::android.view.View.__OnTouchListener.staticClass, "android.view.View.OnTouchListener.onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResources8806;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getResources8806));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getResources8806));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParent8807;
		public virtual global::android.view.ViewParent getParent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getParent8807));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getParent8807));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId8808;
		public virtual int getId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getId8808);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getId8808);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext8809;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getContext8809));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getContext8809));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque8810;
		public virtual bool isOpaque() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isOpaque8810);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isOpaque8810);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHandler8811;
		public virtual global::android.os.Handler getHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getHandler8811));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getHandler8811));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate8812;
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.staticClass, global::android.view.View._inflate8812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTag8813;
		public virtual global::java.lang.Object getTag(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTag8813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTag8813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTag8814;
		public virtual global::java.lang.Object getTag() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTag8814));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTag8814));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidate8815;
		public virtual void invalidate(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._invalidate8815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidate8815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidate8816;
		public virtual void invalidate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._invalidate8816);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidate8816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidate8817;
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._invalidate8817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidate8817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _layout8818;
		public virtual void layout(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._layout8818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._layout8818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged8819;
		protected virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onConfigurationChanged8819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onConfigurationChanged8819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled8820;
		public virtual bool isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isEnabled8820);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isEnabled8820);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled8821;
		public virtual void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setEnabled8821, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setEnabled8821, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentDescription8822;
		public virtual global::java.lang.CharSequence getContentDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getContentDescription8822));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getContentDescription8822));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentDescription8823;
		public virtual void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setContentDescription8823, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setContentDescription8823, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation8824;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getAnimation8824));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getAnimation8824));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw8825;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._draw8825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._draw8825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth8826;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getWidth8826);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getWidth8826);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight8827;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getHeight8827);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getHeight8827);
		}
		internal static global::net.sf.jni4net.jni.MethodId _post8828;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._post8828, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._post8828, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postDelayed8829;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._postDelayed8829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._postDelayed8829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks8830;
		public virtual bool removeCallbacks(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._removeCallbacks8830, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._removeCallbacks8830, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState8831;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onRestoreInstanceState8831, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onRestoreInstanceState8831, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState8832;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._onSaveInstanceState8832));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._onSaveInstanceState8832));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewById8833;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._findViewById8833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._findViewById8833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown8834;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyDown8834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyDown8834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress8835;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyLongPress8835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyLongPress8835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp8836;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyUp8836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyUp8836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple8837;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyMultiple8837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyMultiple8837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8838;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onTouchEvent8838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onTouchEvent8838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent8839;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onTrackballEvent8839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onTrackballEvent8839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged8840;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onWindowFocusChanged8840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onWindowFocusChanged8840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus8841;
		public virtual bool hasFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._hasFocus8841);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._hasFocus8841);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow8842;
		protected virtual void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onAttachedToWindow8842);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onAttachedToWindow8842);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow8843;
		protected virtual void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onDetachedFromWindow8843);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDetachedFromWindow8843);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus8844;
		public virtual bool hasWindowFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._hasWindowFocus8844);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._hasWindowFocus8844);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent8845;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchKeyEvent8845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEvent8845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent8846;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchTouchEvent8846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchTouchEvent8846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent8847;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchTrackballEvent8847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchTrackballEvent8847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent8848;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchPopulateAccessibilityEvent8848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchPopulateAccessibilityEvent8848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu8849;
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onCreateContextMenu8849, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onCreateContextMenu8849, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable8850;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setBackgroundDrawable8850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setBackgroundDrawable8850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState8851;
		public virtual void saveHierarchyState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._saveHierarchyState8851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._saveHierarchyState8851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState8852;
		public virtual void restoreHierarchyState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._restoreHierarchyState8852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._restoreHierarchyState8852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _initializeFadingEdge8853;
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._initializeFadingEdge8853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._initializeFadingEdge8853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalFadingEdgeLength8854;
		public virtual int getVerticalFadingEdgeLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getVerticalFadingEdgeLength8854);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getVerticalFadingEdgeLength8854);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFadingEdgeLength8855;
		public virtual void setFadingEdgeLength(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setFadingEdgeLength8855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setFadingEdgeLength8855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalFadingEdgeLength8856;
		public virtual int getHorizontalFadingEdgeLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getHorizontalFadingEdgeLength8856);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getHorizontalFadingEdgeLength8856);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalScrollbarWidth8857;
		public virtual int getVerticalScrollbarWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getVerticalScrollbarWidth8857);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getVerticalScrollbarWidth8857);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalScrollbarHeight8858;
		protected virtual int getHorizontalScrollbarHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getHorizontalScrollbarHeight8858);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getHorizontalScrollbarHeight8858);
		}
		internal static global::net.sf.jni4net.jni.MethodId _initializeScrollbars8859;
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._initializeScrollbars8859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._initializeScrollbars8859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnFocusChangeListener8860;
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setOnFocusChangeListener8860, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnFocusChangeListener8860, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnFocusChangeListener8861;
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.View.OnFocusChangeListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getOnFocusChangeListener8861));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.View.OnFocusChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getOnFocusChangeListener8861));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener8862;
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setOnClickListener8862, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnClickListener8862, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnLongClickListener8863;
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setOnLongClickListener8863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnLongClickListener8863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCreateContextMenuListener8864;
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setOnCreateContextMenuListener8864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnCreateContextMenuListener8864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performClick8865;
		public virtual bool performClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._performClick8865);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performClick8865);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick8866;
		public virtual bool performLongClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._performLongClick8866);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performLongClick8866);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenu8867;
		public virtual bool showContextMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._showContextMenu8867);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._showContextMenu8867);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener8868;
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setOnKeyListener8868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnKeyListener8868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnTouchListener8869;
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setOnTouchListener8869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnTouchListener8869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestRectangleOnScreen8870;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._requestRectangleOnScreen8870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen8870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestRectangleOnScreen8871;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._requestRectangleOnScreen8871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen8871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearFocus8872;
		public virtual void clearFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._clearFocus8872);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._clearFocus8872);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFocusable8873;
		public virtual bool hasFocusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._hasFocusable8873);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._hasFocusable8873);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged8874;
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onFocusChanged8874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onFocusChanged8874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEvent8875;
		public virtual void sendAccessibilityEvent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._sendAccessibilityEvent8875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEvent8875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEventUnchecked8876;
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._sendAccessibilityEventUnchecked8876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEventUnchecked8876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFocused8877;
		public virtual bool isFocused() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isFocused8877);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isFocused8877);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findFocus8878;
		public virtual global::android.view.View findFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._findFocus8878));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._findFocus8878));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollContainer8879;
		public virtual void setScrollContainer(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setScrollContainer8879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setScrollContainer8879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCacheQuality8880;
		public virtual int getDrawingCacheQuality() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getDrawingCacheQuality8880);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheQuality8880);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheQuality8881;
		public virtual void setDrawingCacheQuality(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setDrawingCacheQuality8881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheQuality8881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeepScreenOn8882;
		public virtual bool getKeepScreenOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._getKeepScreenOn8882);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getKeepScreenOn8882);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeepScreenOn8883;
		public virtual void setKeepScreenOn(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setKeepScreenOn8883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setKeepScreenOn8883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusLeftId8884;
		public virtual int getNextFocusLeftId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusLeftId8884);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusLeftId8884);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusLeftId8885;
		public virtual void setNextFocusLeftId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusLeftId8885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusLeftId8885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusRightId8886;
		public virtual int getNextFocusRightId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusRightId8886);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusRightId8886);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusRightId8887;
		public virtual void setNextFocusRightId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusRightId8887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusRightId8887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusUpId8888;
		public virtual int getNextFocusUpId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusUpId8888);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusUpId8888);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusUpId8889;
		public virtual void setNextFocusUpId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusUpId8889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusUpId8889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusDownId8890;
		public virtual int getNextFocusDownId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusDownId8890);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusDownId8890);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusDownId8891;
		public virtual void setNextFocusDownId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusDownId8891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusDownId8891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShown8892;
		public virtual bool isShown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isShown8892);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isShown8892);
		}
		internal static global::net.sf.jni4net.jni.MethodId _fitSystemWindows8893;
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._fitSystemWindows8893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._fitSystemWindows8893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVisibility8894;
		public virtual int getVisibility() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getVisibility8894);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getVisibility8894);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility8895;
		public virtual void setVisibility(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setVisibility8895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setVisibility8895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable8896;
		public virtual void setFocusable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setFocusable8896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setFocusable8896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFocusableInTouchMode8897;
		public virtual void setFocusableInTouchMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setFocusableInTouchMode8897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setFocusableInTouchMode8897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSoundEffectsEnabled8898;
		public virtual void setSoundEffectsEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setSoundEffectsEnabled8898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setSoundEffectsEnabled8898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSoundEffectsEnabled8899;
		public virtual bool isSoundEffectsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isSoundEffectsEnabled8899);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isSoundEffectsEnabled8899);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHapticFeedbackEnabled8900;
		public virtual void setHapticFeedbackEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setHapticFeedbackEnabled8900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setHapticFeedbackEnabled8900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHapticFeedbackEnabled8901;
		public virtual bool isHapticFeedbackEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isHapticFeedbackEnabled8901);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isHapticFeedbackEnabled8901);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWillNotDraw8902;
		public virtual void setWillNotDraw(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setWillNotDraw8902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setWillNotDraw8902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _willNotDraw8903;
		public virtual bool willNotDraw() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._willNotDraw8903);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._willNotDraw8903);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWillNotCacheDrawing8904;
		public virtual void setWillNotCacheDrawing(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setWillNotCacheDrawing8904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setWillNotCacheDrawing8904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _willNotCacheDrawing8905;
		public virtual bool willNotCacheDrawing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._willNotCacheDrawing8905);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._willNotCacheDrawing8905);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isClickable8906;
		public virtual bool isClickable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isClickable8906);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isClickable8906);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClickable8907;
		public virtual void setClickable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setClickable8907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setClickable8907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLongClickable8908;
		public virtual bool isLongClickable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isLongClickable8908);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isLongClickable8908);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLongClickable8909;
		public virtual void setLongClickable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setLongClickable8909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setLongClickable8909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPressed8910;
		public virtual void setPressed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setPressed8910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setPressed8910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed8911;
		protected virtual void dispatchSetPressed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchSetPressed8911, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchSetPressed8911, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPressed8912;
		public virtual bool isPressed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isPressed8912);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isPressed8912);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSaveEnabled8913;
		public virtual bool isSaveEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isSaveEnabled8913);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isSaveEnabled8913);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSaveEnabled8914;
		public virtual void setSaveEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setSaveEnabled8914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setSaveEnabled8914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFocusable8915;
		public virtual bool isFocusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isFocusable8915);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isFocusable8915);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFocusableInTouchMode8916;
		public virtual bool isFocusableInTouchMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isFocusableInTouchMode8916);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isFocusableInTouchMode8916);
		}
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch8917;
		public virtual global::android.view.View focusSearch(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._focusSearch8917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._focusSearch8917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove8918;
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchUnhandledMove8918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchUnhandledMove8918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusables8919;
		public virtual global::java.util.ArrayList getFocusables(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getFocusables8919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getFocusables8919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables8920;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._addFocusables8920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._addFocusables8920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables8921;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._addFocusables8921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._addFocusables8921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTouchables8922;
		public virtual global::java.util.ArrayList getTouchables() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTouchables8922));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTouchables8922));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables8923;
		public virtual void addTouchables(java.util.ArrayList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._addTouchables8923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._addTouchables8923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8924;
		public virtual bool requestFocus(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocus8924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocus8924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8925;
		public virtual bool requestFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocus8925);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocus8925);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8926;
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocus8926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocus8926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocusFromTouch8927;
		public virtual bool requestFocusFromTouch() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocusFromTouch8927);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocusFromTouch8927);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStartTemporaryDetach8928;
		public virtual void onStartTemporaryDetach() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onStartTemporaryDetach8928);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onStartTemporaryDetach8928);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishTemporaryDetach8929;
		public virtual void onFinishTemporaryDetach() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onFinishTemporaryDetach8929);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onFinishTemporaryDetach8929);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyDispatcherState8930;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getKeyDispatcherState8930));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getKeyDispatcherState8930));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEventPreIme8931;
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchKeyEventPreIme8931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEventPreIme8931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyShortcutEvent8932;
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchKeyShortcutEvent8932, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchKeyShortcutEvent8932, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged8933;
		public virtual void dispatchWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchWindowFocusChanged8933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchWindowFocusChanged8933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchVisibilityChanged8934;
		protected virtual void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchVisibilityChanged8934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchVisibilityChanged8934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged8935;
		protected virtual void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onVisibilityChanged8935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onVisibilityChanged8935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDisplayHint8936;
		public virtual void dispatchDisplayHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchDisplayHint8936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchDisplayHint8936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisplayHint8937;
		protected virtual void onDisplayHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onDisplayHint8937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDisplayHint8937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowVisibilityChanged8938;
		public virtual void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchWindowVisibilityChanged8938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchWindowVisibilityChanged8938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged8939;
		protected virtual void onWindowVisibilityChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onWindowVisibilityChanged8939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onWindowVisibilityChanged8939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowVisibility8940;
		public virtual int getWindowVisibility() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getWindowVisibility8940);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getWindowVisibility8940);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowVisibleDisplayFrame8941;
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._getWindowVisibleDisplayFrame8941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getWindowVisibleDisplayFrame8941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchConfigurationChanged8942;
		public virtual void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchConfigurationChanged8942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchConfigurationChanged8942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInTouchMode8943;
		public virtual bool isInTouchMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isInTouchMode8943);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isInTouchMode8943);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyPreIme8944;
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyPreIme8944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyPreIme8944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyShortcut8945;
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyShortcut8945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyShortcut8945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCheckIsTextEditor8946;
		public virtual bool onCheckIsTextEditor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onCheckIsTextEditor8946);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onCheckIsTextEditor8946);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection8947;
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._onCreateInputConnection8947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._onCreateInputConnection8947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkInputConnectionProxy8948;
		public virtual bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._checkInputConnectionProxy8948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._checkInputConnectionProxy8948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createContextMenu8949;
		public virtual void createContextMenu(android.view.ContextMenu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._createContextMenu8949, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._createContextMenu8949, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo8950;
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getContextMenuInfo8950));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getContextMenuInfo8950));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelLongPress8951;
		public virtual void cancelLongPress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._cancelLongPress8951);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._cancelLongPress8951);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTouchDelegate8952;
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setTouchDelegate8952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setTouchDelegate8952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTouchDelegate8953;
		public virtual global::android.view.TouchDelegate getTouchDelegate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.TouchDelegate>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTouchDelegate8953));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.TouchDelegate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTouchDelegate8953));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bringToFront8954;
		public virtual void bringToFront() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._bringToFront8954);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._bringToFront8954);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged8955;
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onScrollChanged8955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onScrollChanged8955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged8956;
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onSizeChanged8956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onSizeChanged8956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw8957;
		protected virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchDraw8957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchDraw8957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollX8958;
		public virtual int getScrollX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getScrollX8958);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getScrollX8958);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollY8959;
		public virtual int getScrollY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getScrollY8959);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getScrollY8959);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingRect8960;
		public virtual void getDrawingRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._getDrawingRect8960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingRect8960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMeasuredWidth8961;
		public virtual int getMeasuredWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getMeasuredWidth8961);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getMeasuredWidth8961);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMeasuredHeight8962;
		public virtual int getMeasuredHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getMeasuredHeight8962);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getMeasuredHeight8962);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTop8963;
		public virtual int getTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getTop8963);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getTop8963);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottom8964;
		public virtual int getBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getBottom8964);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getBottom8964);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeft8965;
		public virtual int getLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getLeft8965);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getLeft8965);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRight8966;
		public virtual int getRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getRight8966);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getRight8966);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHitRect8967;
		public virtual void getHitRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._getHitRect8967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getHitRect8967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect8968;
		public virtual void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._getFocusedRect8968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getFocusedRect8968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalVisibleRect8969;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._getGlobalVisibleRect8969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect8969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalVisibleRect8970;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._getGlobalVisibleRect8970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect8970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalVisibleRect8971;
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._getLocalVisibleRect8971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getLocalVisibleRect8971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetTopAndBottom8972;
		public virtual void offsetTopAndBottom(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._offsetTopAndBottom8972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._offsetTopAndBottom8972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetLeftAndRight8973;
		public virtual void offsetLeftAndRight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._offsetLeftAndRight8973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._offsetLeftAndRight8973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutParams8974;
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getLayoutParams8974));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getLayoutParams8974));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutParams8975;
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setLayoutParams8975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setLayoutParams8975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo8976;
		public virtual void scrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._scrollTo8976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._scrollTo8976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scrollBy8977;
		public virtual void scrollBy(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._scrollBy8977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._scrollBy8977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars8978;
		protected virtual bool awakenScrollBars(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._awakenScrollBars8978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars8978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars8979;
		protected virtual bool awakenScrollBars() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._awakenScrollBars8979);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars8979);
		}
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars8980;
		protected virtual bool awakenScrollBars(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._awakenScrollBars8980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars8980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate8981;
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidate8981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidate8981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate8982;
		public virtual void postInvalidate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidate8982);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidate8982);
		}
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidateDelayed8983;
		public virtual void postInvalidateDelayed(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidateDelayed8983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed8983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidateDelayed8984;
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidateDelayed8984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed8984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll8985;
		public virtual void computeScroll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._computeScroll8985);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._computeScroll8985);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontalFadingEdgeEnabled8986;
		public virtual bool isHorizontalFadingEdgeEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isHorizontalFadingEdgeEnabled8986);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isHorizontalFadingEdgeEnabled8986);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalFadingEdgeEnabled8987;
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setHorizontalFadingEdgeEnabled8987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setHorizontalFadingEdgeEnabled8987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVerticalFadingEdgeEnabled8988;
		public virtual bool isVerticalFadingEdgeEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isVerticalFadingEdgeEnabled8988);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isVerticalFadingEdgeEnabled8988);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalFadingEdgeEnabled8989;
		public virtual void setVerticalFadingEdgeEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setVerticalFadingEdgeEnabled8989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setVerticalFadingEdgeEnabled8989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength8990;
		protected virtual float getTopFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.View._getTopFadingEdgeStrength8990);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getTopFadingEdgeStrength8990);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength8991;
		protected virtual float getBottomFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.View._getBottomFadingEdgeStrength8991);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getBottomFadingEdgeStrength8991);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength8992;
		protected virtual float getLeftFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.View._getLeftFadingEdgeStrength8992);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getLeftFadingEdgeStrength8992);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength8993;
		protected virtual float getRightFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.View._getRightFadingEdgeStrength8993);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getRightFadingEdgeStrength8993);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontalScrollBarEnabled8994;
		public virtual bool isHorizontalScrollBarEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isHorizontalScrollBarEnabled8994);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isHorizontalScrollBarEnabled8994);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalScrollBarEnabled8995;
		public virtual void setHorizontalScrollBarEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setHorizontalScrollBarEnabled8995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setHorizontalScrollBarEnabled8995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVerticalScrollBarEnabled8996;
		public virtual bool isVerticalScrollBarEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isVerticalScrollBarEnabled8996);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isVerticalScrollBarEnabled8996);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalScrollBarEnabled8997;
		public virtual void setVerticalScrollBarEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setVerticalScrollBarEnabled8997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setVerticalScrollBarEnabled8997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollbarFadingEnabled8998;
		public virtual void setScrollbarFadingEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setScrollbarFadingEnabled8998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setScrollbarFadingEnabled8998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isScrollbarFadingEnabled8999;
		public virtual bool isScrollbarFadingEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isScrollbarFadingEnabled8999);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isScrollbarFadingEnabled8999);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollBarStyle9000;
		public virtual void setScrollBarStyle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setScrollBarStyle9000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setScrollBarStyle9000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarStyle9001;
		public virtual int getScrollBarStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getScrollBarStyle9001);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getScrollBarStyle9001);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange9002;
		protected virtual int computeHorizontalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._computeHorizontalScrollRange9002);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollRange9002);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollOffset9003;
		protected virtual int computeHorizontalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._computeHorizontalScrollOffset9003);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollOffset9003);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollExtent9004;
		protected virtual int computeHorizontalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._computeHorizontalScrollExtent9004);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollExtent9004);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange9005;
		protected virtual int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._computeVerticalScrollRange9005);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollRange9005);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset9006;
		protected virtual int computeVerticalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._computeVerticalScrollOffset9006);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollOffset9006);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent9007;
		protected virtual int computeVerticalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._computeVerticalScrollExtent9007);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollExtent9007);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDrawScrollBars9008;
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onDrawScrollBars9008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDrawScrollBars9008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9009;
		protected virtual void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onDraw9009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDraw9009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowAttachCount9010;
		protected virtual int getWindowAttachCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getWindowAttachCount9010);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getWindowAttachCount9010);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowToken9011;
		public virtual global::android.os.IBinder getWindowToken() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getWindowToken9011));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getWindowToken9011));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationWindowToken9012;
		public virtual global::android.os.IBinder getApplicationWindowToken() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getApplicationWindowToken9012));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getApplicationWindowToken9012));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState9013;
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchSaveInstanceState9013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchSaveInstanceState9013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState9014;
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchRestoreInstanceState9014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchRestoreInstanceState9014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingTime9015;
		public virtual long getDrawingTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.View._getDrawingTime9015);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingTime9015);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDuplicateParentStateEnabled9016;
		public virtual void setDuplicateParentStateEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setDuplicateParentStateEnabled9016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDuplicateParentStateEnabled9016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDuplicateParentStateEnabled9017;
		public virtual bool isDuplicateParentStateEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isDuplicateParentStateEnabled9017);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isDuplicateParentStateEnabled9017);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheEnabled9018;
		public virtual void setDrawingCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setDrawingCacheEnabled9018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheEnabled9018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDrawingCacheEnabled9019;
		public virtual bool isDrawingCacheEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isDrawingCacheEnabled9019);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isDrawingCacheEnabled9019);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCache9020;
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getDrawingCache9020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCache9020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCache9021;
		public virtual global::android.graphics.Bitmap getDrawingCache() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getDrawingCache9021));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCache9021));
		}
		internal static global::net.sf.jni4net.jni.MethodId _destroyDrawingCache9022;
		public virtual void destroyDrawingCache() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._destroyDrawingCache9022);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._destroyDrawingCache9022);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheBackgroundColor9023;
		public virtual void setDrawingCacheBackgroundColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setDrawingCacheBackgroundColor9023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheBackgroundColor9023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCacheBackgroundColor9024;
		public virtual int getDrawingCacheBackgroundColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getDrawingCacheBackgroundColor9024);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheBackgroundColor9024);
		}
		internal static global::net.sf.jni4net.jni.MethodId _buildDrawingCache9025;
		public virtual void buildDrawingCache() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._buildDrawingCache9025);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache9025);
		}
		internal static global::net.sf.jni4net.jni.MethodId _buildDrawingCache9026;
		public virtual void buildDrawingCache(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._buildDrawingCache9026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache9026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInEditMode9027;
		public virtual bool isInEditMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isInEditMode9027);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isInEditMode9027);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPaddingOffsetRequired9028;
		protected virtual bool isPaddingOffsetRequired() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isPaddingOffsetRequired9028);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isPaddingOffsetRequired9028);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeftPaddingOffset9029;
		protected virtual int getLeftPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getLeftPaddingOffset9029);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getLeftPaddingOffset9029);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRightPaddingOffset9030;
		protected virtual int getRightPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getRightPaddingOffset9030);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getRightPaddingOffset9030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopPaddingOffset9031;
		protected virtual int getTopPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getTopPaddingOffset9031);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getTopPaddingOffset9031);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPaddingOffset9032;
		protected virtual int getBottomPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getBottomPaddingOffset9032);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getBottomPaddingOffset9032);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSolidColor9033;
		public virtual int getSolidColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getSolidColor9033);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getSolidColor9033);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLayoutRequested9034;
		public virtual bool isLayoutRequested() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isLayoutRequested9034);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isLayoutRequested9034);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9035;
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onLayout9035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onLayout9035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate9036;
		protected virtual void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onFinishInflate9036);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onFinishInflate9036);
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable9037;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._invalidateDrawable9037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidateDrawable9037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable9038;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._scheduleDrawable9038, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._scheduleDrawable9038, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable9039;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._unscheduleDrawable9039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable9039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable9040;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._unscheduleDrawable9040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable9040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9041;
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._verifyDrawable9041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._verifyDrawable9041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9042;
		protected virtual void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._drawableStateChanged9042);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._drawableStateChanged9042);
		}
		internal static global::net.sf.jni4net.jni.MethodId _refreshDrawableState9043;
		public virtual void refreshDrawableState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._refreshDrawableState9043);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._refreshDrawableState9043);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawableState9044;
		public virtual int[] getDrawableState() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getDrawableState9044));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getDrawableState9044));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9045;
		protected virtual int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._onCreateDrawableState9045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._onCreateDrawableState9045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mergeDrawableStates9046;
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.staticClass, global::android.view.View._mergeDrawableStates9046, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundColor9047;
		public virtual void setBackgroundColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setBackgroundColor9047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setBackgroundColor9047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundResource9048;
		public virtual void setBackgroundResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setBackgroundResource9048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setBackgroundResource9048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBackground9049;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getBackground9049));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getBackground9049));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPadding9050;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setPadding9050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setPadding9050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingTop9051;
		public virtual int getPaddingTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingTop9051);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingTop9051);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingBottom9052;
		public virtual int getPaddingBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingBottom9052);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingBottom9052);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingLeft9053;
		public virtual int getPaddingLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingLeft9053);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingLeft9053);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingRight9054;
		public virtual int getPaddingRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingRight9054);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingRight9054);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelected9055;
		public virtual void setSelected(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setSelected9055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setSelected9055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected9056;
		protected virtual void dispatchSetSelected(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._dispatchSetSelected9056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchSetSelected9056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSelected9057;
		public virtual bool isSelected() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._isSelected9057);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isSelected9057);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTreeObserver9058;
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewTreeObserver>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getViewTreeObserver9058));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewTreeObserver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getViewTreeObserver9058));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRootView9059;
		public virtual global::android.view.View getRootView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getRootView9059));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getRootView9059));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocationOnScreen9060;
		public virtual void getLocationOnScreen(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._getLocationOnScreen9060, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getLocationOnScreen9060, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocationInWindow9061;
		public virtual void getLocationInWindow(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._getLocationInWindow9061, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getLocationInWindow9061, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewWithTag9062;
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._findViewWithTag9062, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._findViewWithTag9062, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setId9063;
		public virtual void setId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setId9063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setId9063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTag9064;
		public virtual void setTag(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setTag9064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setTag9064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTag9065;
		public virtual void setTag(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setTag9065, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setTag9065, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline9066;
		public virtual int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getBaseline9066);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getBaseline9066);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9067;
		public virtual void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._requestLayout9067);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._requestLayout9067);
		}
		internal static global::net.sf.jni4net.jni.MethodId _forceLayout9068;
		public virtual void forceLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._forceLayout9068);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._forceLayout9068);
		}
		internal static global::net.sf.jni4net.jni.MethodId _measure9069;
		public virtual void measure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._measure9069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._measure9069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9070;
		protected virtual void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onMeasure9070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onMeasure9070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMeasuredDimension9071;
		protected virtual void setMeasuredDimension(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setMeasuredDimension9071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setMeasuredDimension9071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveSize9072;
		public static int resolveSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._resolveSize9072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultSize9073;
		public static int getDefaultSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._getDefaultSize9073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestedMinimumHeight9074;
		protected virtual int getSuggestedMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getSuggestedMinimumHeight9074);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumHeight9074);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestedMinimumWidth9075;
		protected virtual int getSuggestedMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.View._getSuggestedMinimumWidth9075);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumWidth9075);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumHeight9076;
		public virtual void setMinimumHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setMinimumHeight9076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setMinimumHeight9076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumWidth9077;
		public virtual void setMinimumWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setMinimumWidth9077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setMinimumWidth9077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startAnimation9078;
		public virtual void startAnimation(android.view.animation.Animation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._startAnimation9078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._startAnimation9078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearAnimation9079;
		public virtual void clearAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._clearAnimation9079);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._clearAnimation9079);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation9080;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._setAnimation9080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setAnimation9080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart9081;
		protected virtual void onAnimationStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onAnimationStart9081);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onAnimationStart9081);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd9082;
		protected virtual void onAnimationEnd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._onAnimationEnd9082);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onAnimationEnd9082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetAlpha9083;
		protected virtual bool onSetAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._onSetAlpha9083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onSetAlpha9083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect9084;
		public virtual void playSoundEffect(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.View._playSoundEffect9084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._playSoundEffect9084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performHapticFeedback9085;
		public virtual bool performHapticFeedback(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._performHapticFeedback9085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback9085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performHapticFeedback9086;
		public virtual bool performHapticFeedback(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.View._performHapticFeedback9086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback9086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _View9087;
		public View(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.View.staticClass, global::android.view.View._View9087, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _View9088;
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.View.staticClass, global::android.view.View._View9088, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _View9089;
		public View(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.View.staticClass, global::android.view.View._View9089, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.View.staticClass = @__class;
			global::android.view.View._getResources8806 = @__env.GetMethodID(global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.view.View._getParent8807 = @__env.GetMethodID(global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;");
			global::android.view.View._getId8808 = @__env.GetMethodID(global::android.view.View.staticClass, "getId", "()I");
			global::android.view.View._getContext8809 = @__env.GetMethodID(global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.View._isOpaque8810 = @__env.GetMethodID(global::android.view.View.staticClass, "isOpaque", "()Z");
			global::android.view.View._getHandler8811 = @__env.GetMethodID(global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;");
			global::android.view.View._inflate8812 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.View._getTag8813 = @__env.GetMethodID(global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;");
			global::android.view.View._getTag8814 = @__env.GetMethodID(global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;");
			global::android.view.View._invalidate8815 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V");
			global::android.view.View._invalidate8816 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "()V");
			global::android.view.View._invalidate8817 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "(IIII)V");
			global::android.view.View._layout8818 = @__env.GetMethodID(global::android.view.View.staticClass, "layout", "(IIII)V");
			global::android.view.View._onConfigurationChanged8819 = @__env.GetMethodID(global::android.view.View.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isEnabled8820 = @__env.GetMethodID(global::android.view.View.staticClass, "isEnabled", "()Z");
			global::android.view.View._setEnabled8821 = @__env.GetMethodID(global::android.view.View.staticClass, "setEnabled", "(Z)V");
			global::android.view.View._getContentDescription8822 = @__env.GetMethodID(global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.View._setContentDescription8823 = @__env.GetMethodID(global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.View._getAnimation8824 = @__env.GetMethodID(global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.View._draw8825 = @__env.GetMethodID(global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWidth8826 = @__env.GetMethodID(global::android.view.View.staticClass, "getWidth", "()I");
			global::android.view.View._getHeight8827 = @__env.GetMethodID(global::android.view.View.staticClass, "getHeight", "()I");
			global::android.view.View._post8828 = @__env.GetMethodID(global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._postDelayed8829 = @__env.GetMethodID(global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.view.View._removeCallbacks8830 = @__env.GetMethodID(global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._onRestoreInstanceState8831 = @__env.GetMethodID(global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.view.View._onSaveInstanceState8832 = @__env.GetMethodID(global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.view.View._findViewById8833 = @__env.GetMethodID(global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.View._onKeyDown8834 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyLongPress8835 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyUp8836 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyMultiple8837 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.view.View._onTouchEvent8838 = @__env.GetMethodID(global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onTrackballEvent8839 = @__env.GetMethodID(global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onWindowFocusChanged8840 = @__env.GetMethodID(global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.view.View._hasFocus8841 = @__env.GetMethodID(global::android.view.View.staticClass, "hasFocus", "()Z");
			global::android.view.View._onAttachedToWindow8842 = @__env.GetMethodID(global::android.view.View.staticClass, "onAttachedToWindow", "()V");
			global::android.view.View._onDetachedFromWindow8843 = @__env.GetMethodID(global::android.view.View.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.View._hasWindowFocus8844 = @__env.GetMethodID(global::android.view.View.staticClass, "hasWindowFocus", "()Z");
			global::android.view.View._dispatchKeyEvent8845 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchTouchEvent8846 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchTrackballEvent8847 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchPopulateAccessibilityEvent8848 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.View._onCreateContextMenu8849 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._setBackgroundDrawable8850 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._saveHierarchyState8851 = @__env.GetMethodID(global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._restoreHierarchyState8852 = @__env.GetMethodID(global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._initializeFadingEdge8853 = @__env.GetMethodID(global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._getVerticalFadingEdgeLength8854 = @__env.GetMethodID(global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I");
			global::android.view.View._setFadingEdgeLength8855 = @__env.GetMethodID(global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V");
			global::android.view.View._getHorizontalFadingEdgeLength8856 = @__env.GetMethodID(global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I");
			global::android.view.View._getVerticalScrollbarWidth8857 = @__env.GetMethodID(global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I");
			global::android.view.View._getHorizontalScrollbarHeight8858 = @__env.GetMethodID(global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I");
			global::android.view.View._initializeScrollbars8859 = @__env.GetMethodID(global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._setOnFocusChangeListener8860 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V");
			global::android.view.View._getOnFocusChangeListener8861 = @__env.GetMethodID(global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;");
			global::android.view.View._setOnClickListener8862 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.view.View._setOnLongClickListener8863 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V");
			global::android.view.View._setOnCreateContextMenuListener8864 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V");
			global::android.view.View._performClick8865 = @__env.GetMethodID(global::android.view.View.staticClass, "performClick", "()Z");
			global::android.view.View._performLongClick8866 = @__env.GetMethodID(global::android.view.View.staticClass, "performLongClick", "()Z");
			global::android.view.View._showContextMenu8867 = @__env.GetMethodID(global::android.view.View.staticClass, "showContextMenu", "()Z");
			global::android.view.View._setOnKeyListener8868 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V");
			global::android.view.View._setOnTouchListener8869 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V");
			global::android.view.View._requestRectangleOnScreen8870 = @__env.GetMethodID(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._requestRectangleOnScreen8871 = @__env.GetMethodID(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z");
			global::android.view.View._clearFocus8872 = @__env.GetMethodID(global::android.view.View.staticClass, "clearFocus", "()V");
			global::android.view.View._hasFocusable8873 = @__env.GetMethodID(global::android.view.View.staticClass, "hasFocusable", "()Z");
			global::android.view.View._onFocusChanged8874 = @__env.GetMethodID(global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.view.View._sendAccessibilityEvent8875 = @__env.GetMethodID(global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V");
			global::android.view.View._sendAccessibilityEventUnchecked8876 = @__env.GetMethodID(global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.View._isFocused8877 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocused", "()Z");
			global::android.view.View._findFocus8878 = @__env.GetMethodID(global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.View._setScrollContainer8879 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollContainer", "(Z)V");
			global::android.view.View._getDrawingCacheQuality8880 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCacheQuality", "()I");
			global::android.view.View._setDrawingCacheQuality8881 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V");
			global::android.view.View._getKeepScreenOn8882 = @__env.GetMethodID(global::android.view.View.staticClass, "getKeepScreenOn", "()Z");
			global::android.view.View._setKeepScreenOn8883 = @__env.GetMethodID(global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V");
			global::android.view.View._getNextFocusLeftId8884 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusLeftId", "()I");
			global::android.view.View._setNextFocusLeftId8885 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V");
			global::android.view.View._getNextFocusRightId8886 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusRightId", "()I");
			global::android.view.View._setNextFocusRightId8887 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusRightId", "(I)V");
			global::android.view.View._getNextFocusUpId8888 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusUpId", "()I");
			global::android.view.View._setNextFocusUpId8889 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusUpId", "(I)V");
			global::android.view.View._getNextFocusDownId8890 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusDownId", "()I");
			global::android.view.View._setNextFocusDownId8891 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusDownId", "(I)V");
			global::android.view.View._isShown8892 = @__env.GetMethodID(global::android.view.View.staticClass, "isShown", "()Z");
			global::android.view.View._fitSystemWindows8893 = @__env.GetMethodID(global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getVisibility8894 = @__env.GetMethodID(global::android.view.View.staticClass, "getVisibility", "()I");
			global::android.view.View._setVisibility8895 = @__env.GetMethodID(global::android.view.View.staticClass, "setVisibility", "(I)V");
			global::android.view.View._setFocusable8896 = @__env.GetMethodID(global::android.view.View.staticClass, "setFocusable", "(Z)V");
			global::android.view.View._setFocusableInTouchMode8897 = @__env.GetMethodID(global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.view.View._setSoundEffectsEnabled8898 = @__env.GetMethodID(global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V");
			global::android.view.View._isSoundEffectsEnabled8899 = @__env.GetMethodID(global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z");
			global::android.view.View._setHapticFeedbackEnabled8900 = @__env.GetMethodID(global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V");
			global::android.view.View._isHapticFeedbackEnabled8901 = @__env.GetMethodID(global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z");
			global::android.view.View._setWillNotDraw8902 = @__env.GetMethodID(global::android.view.View.staticClass, "setWillNotDraw", "(Z)V");
			global::android.view.View._willNotDraw8903 = @__env.GetMethodID(global::android.view.View.staticClass, "willNotDraw", "()Z");
			global::android.view.View._setWillNotCacheDrawing8904 = @__env.GetMethodID(global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V");
			global::android.view.View._willNotCacheDrawing8905 = @__env.GetMethodID(global::android.view.View.staticClass, "willNotCacheDrawing", "()Z");
			global::android.view.View._isClickable8906 = @__env.GetMethodID(global::android.view.View.staticClass, "isClickable", "()Z");
			global::android.view.View._setClickable8907 = @__env.GetMethodID(global::android.view.View.staticClass, "setClickable", "(Z)V");
			global::android.view.View._isLongClickable8908 = @__env.GetMethodID(global::android.view.View.staticClass, "isLongClickable", "()Z");
			global::android.view.View._setLongClickable8909 = @__env.GetMethodID(global::android.view.View.staticClass, "setLongClickable", "(Z)V");
			global::android.view.View._setPressed8910 = @__env.GetMethodID(global::android.view.View.staticClass, "setPressed", "(Z)V");
			global::android.view.View._dispatchSetPressed8911 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.View._isPressed8912 = @__env.GetMethodID(global::android.view.View.staticClass, "isPressed", "()Z");
			global::android.view.View._isSaveEnabled8913 = @__env.GetMethodID(global::android.view.View.staticClass, "isSaveEnabled", "()Z");
			global::android.view.View._setSaveEnabled8914 = @__env.GetMethodID(global::android.view.View.staticClass, "setSaveEnabled", "(Z)V");
			global::android.view.View._isFocusable8915 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocusable", "()Z");
			global::android.view.View._isFocusableInTouchMode8916 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z");
			global::android.view.View._focusSearch8917 = @__env.GetMethodID(global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;");
			global::android.view.View._dispatchUnhandledMove8918 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.View._getFocusables8919 = @__env.GetMethodID(global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;");
			global::android.view.View._addFocusables8920 = @__env.GetMethodID(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.View._addFocusables8921 = @__env.GetMethodID(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.View._getTouchables8922 = @__env.GetMethodID(global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;");
			global::android.view.View._addTouchables8923 = @__env.GetMethodID(global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.View._requestFocus8924 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "(I)Z");
			global::android.view.View._requestFocus8925 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "()Z");
			global::android.view.View._requestFocus8926 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.View._requestFocusFromTouch8927 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocusFromTouch", "()Z");
			global::android.view.View._onStartTemporaryDetach8928 = @__env.GetMethodID(global::android.view.View.staticClass, "onStartTemporaryDetach", "()V");
			global::android.view.View._onFinishTemporaryDetach8929 = @__env.GetMethodID(global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.view.View._getKeyDispatcherState8930 = @__env.GetMethodID(global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.view.View._dispatchKeyEventPreIme8931 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchKeyShortcutEvent8932 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchWindowFocusChanged8933 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.View._dispatchVisibilityChanged8934 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._onVisibilityChanged8935 = @__env.GetMethodID(global::android.view.View.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._dispatchDisplayHint8936 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.View._onDisplayHint8937 = @__env.GetMethodID(global::android.view.View.staticClass, "onDisplayHint", "(I)V");
			global::android.view.View._dispatchWindowVisibilityChanged8938 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.View._onWindowVisibilityChanged8939 = @__env.GetMethodID(global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.View._getWindowVisibility8940 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowVisibility", "()I");
			global::android.view.View._getWindowVisibleDisplayFrame8941 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V");
			global::android.view.View._dispatchConfigurationChanged8942 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isInTouchMode8943 = @__env.GetMethodID(global::android.view.View.staticClass, "isInTouchMode", "()Z");
			global::android.view.View._onKeyPreIme8944 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyShortcut8945 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onCheckIsTextEditor8946 = @__env.GetMethodID(global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.view.View._onCreateInputConnection8947 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.view.View._checkInputConnectionProxy8948 = @__env.GetMethodID(global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.view.View._createContextMenu8949 = @__env.GetMethodID(global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._getContextMenuInfo8950 = @__env.GetMethodID(global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.view.View._cancelLongPress8951 = @__env.GetMethodID(global::android.view.View.staticClass, "cancelLongPress", "()V");
			global::android.view.View._setTouchDelegate8952 = @__env.GetMethodID(global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V");
			global::android.view.View._getTouchDelegate8953 = @__env.GetMethodID(global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;");
			global::android.view.View._bringToFront8954 = @__env.GetMethodID(global::android.view.View.staticClass, "bringToFront", "()V");
			global::android.view.View._onScrollChanged8955 = @__env.GetMethodID(global::android.view.View.staticClass, "onScrollChanged", "(IIII)V");
			global::android.view.View._onSizeChanged8956 = @__env.GetMethodID(global::android.view.View.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.View._dispatchDraw8957 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getScrollX8958 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollX", "()I");
			global::android.view.View._getScrollY8959 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollY", "()I");
			global::android.view.View._getDrawingRect8960 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getMeasuredWidth8961 = @__env.GetMethodID(global::android.view.View.staticClass, "getMeasuredWidth", "()I");
			global::android.view.View._getMeasuredHeight8962 = @__env.GetMethodID(global::android.view.View.staticClass, "getMeasuredHeight", "()I");
			global::android.view.View._getTop8963 = @__env.GetMethodID(global::android.view.View.staticClass, "getTop", "()I");
			global::android.view.View._getBottom8964 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottom", "()I");
			global::android.view.View._getLeft8965 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeft", "()I");
			global::android.view.View._getRight8966 = @__env.GetMethodID(global::android.view.View.staticClass, "getRight", "()I");
			global::android.view.View._getHitRect8967 = @__env.GetMethodID(global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getFocusedRect8968 = @__env.GetMethodID(global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getGlobalVisibleRect8969 = @__env.GetMethodID(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.View._getGlobalVisibleRect8970 = @__env.GetMethodID(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getLocalVisibleRect8971 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._offsetTopAndBottom8972 = @__env.GetMethodID(global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V");
			global::android.view.View._offsetLeftAndRight8973 = @__env.GetMethodID(global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V");
			global::android.view.View._getLayoutParams8974 = @__env.GetMethodID(global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.View._setLayoutParams8975 = @__env.GetMethodID(global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.View._scrollTo8976 = @__env.GetMethodID(global::android.view.View.staticClass, "scrollTo", "(II)V");
			global::android.view.View._scrollBy8977 = @__env.GetMethodID(global::android.view.View.staticClass, "scrollBy", "(II)V");
			global::android.view.View._awakenScrollBars8978 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z");
			global::android.view.View._awakenScrollBars8979 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "()Z");
			global::android.view.View._awakenScrollBars8980 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "(I)Z");
			global::android.view.View._postInvalidate8981 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidate", "(IIII)V");
			global::android.view.View._postInvalidate8982 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidate", "()V");
			global::android.view.View._postInvalidateDelayed8983 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V");
			global::android.view.View._postInvalidateDelayed8984 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V");
			global::android.view.View._computeScroll8985 = @__env.GetMethodID(global::android.view.View.staticClass, "computeScroll", "()V");
			global::android.view.View._isHorizontalFadingEdgeEnabled8986 = @__env.GetMethodID(global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z");
			global::android.view.View._setHorizontalFadingEdgeEnabled8987 = @__env.GetMethodID(global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._isVerticalFadingEdgeEnabled8988 = @__env.GetMethodID(global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z");
			global::android.view.View._setVerticalFadingEdgeEnabled8989 = @__env.GetMethodID(global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._getTopFadingEdgeStrength8990 = @__env.GetMethodID(global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.view.View._getBottomFadingEdgeStrength8991 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.view.View._getLeftFadingEdgeStrength8992 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.view.View._getRightFadingEdgeStrength8993 = @__env.GetMethodID(global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.view.View._isHorizontalScrollBarEnabled8994 = @__env.GetMethodID(global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z");
			global::android.view.View._setHorizontalScrollBarEnabled8995 = @__env.GetMethodID(global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V");
			global::android.view.View._isVerticalScrollBarEnabled8996 = @__env.GetMethodID(global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z");
			global::android.view.View._setVerticalScrollBarEnabled8997 = @__env.GetMethodID(global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V");
			global::android.view.View._setScrollbarFadingEnabled8998 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V");
			global::android.view.View._isScrollbarFadingEnabled8999 = @__env.GetMethodID(global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z");
			global::android.view.View._setScrollBarStyle9000 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollBarStyle", "(I)V");
			global::android.view.View._getScrollBarStyle9001 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollBarStyle", "()I");
			global::android.view.View._computeHorizontalScrollRange9002 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.view.View._computeHorizontalScrollOffset9003 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.view.View._computeHorizontalScrollExtent9004 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.view.View._computeVerticalScrollRange9005 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollRange", "()I");
			global::android.view.View._computeVerticalScrollOffset9006 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.view.View._computeVerticalScrollExtent9007 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.view.View._onDrawScrollBars9008 = @__env.GetMethodID(global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._onDraw9009 = @__env.GetMethodID(global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWindowAttachCount9010 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowAttachCount", "()I");
			global::android.view.View._getWindowToken9011 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._getApplicationWindowToken9012 = @__env.GetMethodID(global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._dispatchSaveInstanceState9013 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._dispatchRestoreInstanceState9014 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._getDrawingTime9015 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingTime", "()J");
			global::android.view.View._setDuplicateParentStateEnabled9016 = @__env.GetMethodID(global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V");
			global::android.view.View._isDuplicateParentStateEnabled9017 = @__env.GetMethodID(global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z");
			global::android.view.View._setDrawingCacheEnabled9018 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V");
			global::android.view.View._isDrawingCacheEnabled9019 = @__env.GetMethodID(global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z");
			global::android.view.View._getDrawingCache9020 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;");
			global::android.view.View._getDrawingCache9021 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;");
			global::android.view.View._destroyDrawingCache9022 = @__env.GetMethodID(global::android.view.View.staticClass, "destroyDrawingCache", "()V");
			global::android.view.View._setDrawingCacheBackgroundColor9023 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V");
			global::android.view.View._getDrawingCacheBackgroundColor9024 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I");
			global::android.view.View._buildDrawingCache9025 = @__env.GetMethodID(global::android.view.View.staticClass, "buildDrawingCache", "()V");
			global::android.view.View._buildDrawingCache9026 = @__env.GetMethodID(global::android.view.View.staticClass, "buildDrawingCache", "(Z)V");
			global::android.view.View._isInEditMode9027 = @__env.GetMethodID(global::android.view.View.staticClass, "isInEditMode", "()Z");
			global::android.view.View._isPaddingOffsetRequired9028 = @__env.GetMethodID(global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.view.View._getLeftPaddingOffset9029 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeftPaddingOffset", "()I");
			global::android.view.View._getRightPaddingOffset9030 = @__env.GetMethodID(global::android.view.View.staticClass, "getRightPaddingOffset", "()I");
			global::android.view.View._getTopPaddingOffset9031 = @__env.GetMethodID(global::android.view.View.staticClass, "getTopPaddingOffset", "()I");
			global::android.view.View._getBottomPaddingOffset9032 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottomPaddingOffset", "()I");
			global::android.view.View._getSolidColor9033 = @__env.GetMethodID(global::android.view.View.staticClass, "getSolidColor", "()I");
			global::android.view.View._isLayoutRequested9034 = @__env.GetMethodID(global::android.view.View.staticClass, "isLayoutRequested", "()Z");
			global::android.view.View._onLayout9035 = @__env.GetMethodID(global::android.view.View.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.View._onFinishInflate9036 = @__env.GetMethodID(global::android.view.View.staticClass, "onFinishInflate", "()V");
			global::android.view.View._invalidateDrawable9037 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._scheduleDrawable9038 = @__env.GetMethodID(global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.view.View._unscheduleDrawable9039 = @__env.GetMethodID(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.view.View._unscheduleDrawable9040 = @__env.GetMethodID(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._verifyDrawable9041 = @__env.GetMethodID(global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.view.View._drawableStateChanged9042 = @__env.GetMethodID(global::android.view.View.staticClass, "drawableStateChanged", "()V");
			global::android.view.View._refreshDrawableState9043 = @__env.GetMethodID(global::android.view.View.staticClass, "refreshDrawableState", "()V");
			global::android.view.View._getDrawableState9044 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawableState", "()[I");
			global::android.view.View._onCreateDrawableState9045 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.View._mergeDrawableStates9046 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I");
			global::android.view.View._setBackgroundColor9047 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundColor", "(I)V");
			global::android.view.View._setBackgroundResource9048 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundResource", "(I)V");
			global::android.view.View._getBackground9049 = @__env.GetMethodID(global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.View._setPadding9050 = @__env.GetMethodID(global::android.view.View.staticClass, "setPadding", "(IIII)V");
			global::android.view.View._getPaddingTop9051 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingTop", "()I");
			global::android.view.View._getPaddingBottom9052 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingBottom", "()I");
			global::android.view.View._getPaddingLeft9053 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingLeft", "()I");
			global::android.view.View._getPaddingRight9054 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingRight", "()I");
			global::android.view.View._setSelected9055 = @__env.GetMethodID(global::android.view.View.staticClass, "setSelected", "(Z)V");
			global::android.view.View._dispatchSetSelected9056 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.View._isSelected9057 = @__env.GetMethodID(global::android.view.View.staticClass, "isSelected", "()Z");
			global::android.view.View._getViewTreeObserver9058 = @__env.GetMethodID(global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;");
			global::android.view.View._getRootView9059 = @__env.GetMethodID(global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;");
			global::android.view.View._getLocationOnScreen9060 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocationOnScreen", "([I)V");
			global::android.view.View._getLocationInWindow9061 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocationInWindow", "([I)V");
			global::android.view.View._findViewWithTag9062 = @__env.GetMethodID(global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.view.View._setId9063 = @__env.GetMethodID(global::android.view.View.staticClass, "setId", "(I)V");
			global::android.view.View._setTag9064 = @__env.GetMethodID(global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V");
			global::android.view.View._setTag9065 = @__env.GetMethodID(global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V");
			global::android.view.View._getBaseline9066 = @__env.GetMethodID(global::android.view.View.staticClass, "getBaseline", "()I");
			global::android.view.View._requestLayout9067 = @__env.GetMethodID(global::android.view.View.staticClass, "requestLayout", "()V");
			global::android.view.View._forceLayout9068 = @__env.GetMethodID(global::android.view.View.staticClass, "forceLayout", "()V");
			global::android.view.View._measure9069 = @__env.GetMethodID(global::android.view.View.staticClass, "measure", "(II)V");
			global::android.view.View._onMeasure9070 = @__env.GetMethodID(global::android.view.View.staticClass, "onMeasure", "(II)V");
			global::android.view.View._setMeasuredDimension9071 = @__env.GetMethodID(global::android.view.View.staticClass, "setMeasuredDimension", "(II)V");
			global::android.view.View._resolveSize9072 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "resolveSize", "(II)I");
			global::android.view.View._getDefaultSize9073 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "getDefaultSize", "(II)I");
			global::android.view.View._getSuggestedMinimumHeight9074 = @__env.GetMethodID(global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I");
			global::android.view.View._getSuggestedMinimumWidth9075 = @__env.GetMethodID(global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I");
			global::android.view.View._setMinimumHeight9076 = @__env.GetMethodID(global::android.view.View.staticClass, "setMinimumHeight", "(I)V");
			global::android.view.View._setMinimumWidth9077 = @__env.GetMethodID(global::android.view.View.staticClass, "setMinimumWidth", "(I)V");
			global::android.view.View._startAnimation9078 = @__env.GetMethodID(global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._clearAnimation9079 = @__env.GetMethodID(global::android.view.View.staticClass, "clearAnimation", "()V");
			global::android.view.View._setAnimation9080 = @__env.GetMethodID(global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._onAnimationStart9081 = @__env.GetMethodID(global::android.view.View.staticClass, "onAnimationStart", "()V");
			global::android.view.View._onAnimationEnd9082 = @__env.GetMethodID(global::android.view.View.staticClass, "onAnimationEnd", "()V");
			global::android.view.View._onSetAlpha9083 = @__env.GetMethodID(global::android.view.View.staticClass, "onSetAlpha", "(I)Z");
			global::android.view.View._playSoundEffect9084 = @__env.GetMethodID(global::android.view.View.staticClass, "playSoundEffect", "(I)V");
			global::android.view.View._performHapticFeedback9085 = @__env.GetMethodID(global::android.view.View.staticClass, "performHapticFeedback", "(I)Z");
			global::android.view.View._performHapticFeedback9086 = @__env.GetMethodID(global::android.view.View.staticClass, "performHapticFeedback", "(II)Z");
			global::android.view.View._View9087 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.View._View9088 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.View._View9089 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
