namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class ViewTreeObserver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ViewTreeObserver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.ViewTreeObserver(@__env);
			}
		}
		internal ViewTreeObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGlobalFocusChangeListener 
		{
			void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1);
		}

		public partial class OnGlobalFocusChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGlobalFocusChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGlobalFocusChangeListener : java.lang.Object, OnGlobalFocusChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGlobalFocusChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener(@__env);
				}
			}
			internal __OnGlobalFocusChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGlobalFocusChanged9349;
			 void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener._onGlobalFocusChanged9349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener.staticClass, global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener._onGlobalFocusChanged9349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener.staticClass = @__class;
				global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener._onGlobalFocusChanged9349 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener.staticClass, "android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGlobalLayoutListener 
		{
			void onGlobalLayout();
		}

		public partial class OnGlobalLayoutListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGlobalLayoutListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGlobalLayoutListener : java.lang.Object, OnGlobalLayoutListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGlobalLayoutListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnGlobalLayoutListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewTreeObserver.__OnGlobalLayoutListener(@__env);
				}
			}
			internal __OnGlobalLayoutListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGlobalLayout9350;
			 void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalLayoutListener._onGlobalLayout9350);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalLayoutListener.staticClass, global::android.view.ViewTreeObserver.__OnGlobalLayoutListener._onGlobalLayout9350);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewTreeObserver.__OnGlobalLayoutListener.staticClass = @__class;
				global::android.view.ViewTreeObserver.__OnGlobalLayoutListener._onGlobalLayout9350 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnGlobalLayoutListener.staticClass, "android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnPreDrawListener 
		{
			bool onPreDraw();
		}

		public partial class OnPreDrawListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnPreDrawListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnPreDrawListener : java.lang.Object, OnPreDrawListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnPreDrawListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnPreDrawListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewTreeObserver.__OnPreDrawListener(@__env);
				}
			}
			internal __OnPreDrawListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPreDraw9351;
			 bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewTreeObserver.__OnPreDrawListener._onPreDraw9351);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewTreeObserver.__OnPreDrawListener.staticClass, global::android.view.ViewTreeObserver.__OnPreDrawListener._onPreDraw9351);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewTreeObserver.__OnPreDrawListener.staticClass = @__class;
				global::android.view.ViewTreeObserver.__OnPreDrawListener._onPreDraw9351 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnPreDrawListener.staticClass, "android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw", "()Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnScrollChangedListener 
		{
			void onScrollChanged();
		}

		public partial class OnScrollChangedListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnScrollChangedListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnScrollChangedListener : java.lang.Object, OnScrollChangedListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnScrollChangedListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnScrollChangedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewTreeObserver.__OnScrollChangedListener(@__env);
				}
			}
			internal __OnScrollChangedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged9352;
			 void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnScrollChangedListener._onScrollChanged9352);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnScrollChangedListener.staticClass, global::android.view.ViewTreeObserver.__OnScrollChangedListener._onScrollChanged9352);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewTreeObserver.__OnScrollChangedListener.staticClass = @__class;
				global::android.view.ViewTreeObserver.__OnScrollChangedListener._onScrollChanged9352 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnScrollChangedListener.staticClass, "android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnTouchModeChangeListener 
		{
			void onTouchModeChanged(bool arg0);
		}

		public partial class OnTouchModeChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnTouchModeChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnTouchModeChangeListener : java.lang.Object, OnTouchModeChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnTouchModeChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnTouchModeChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewTreeObserver.__OnTouchModeChangeListener(@__env);
				}
			}
			internal __OnTouchModeChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged9353;
			 void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnTouchModeChangeListener._onTouchModeChanged9353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnTouchModeChangeListener.staticClass, global::android.view.ViewTreeObserver.__OnTouchModeChangeListener._onTouchModeChanged9353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewTreeObserver.__OnTouchModeChangeListener.staticClass = @__class;
				global::android.view.ViewTreeObserver.__OnTouchModeChangeListener._onTouchModeChanged9353 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnTouchModeChangeListener.staticClass, "android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged", "(Z)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAlive9354;
		public bool isAlive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewTreeObserver._isAlive9354);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._isAlive9354);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnGlobalFocusChangeListener9355;
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener9355, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener9355, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGlobalFocusChangeListener9356;
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener9356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener9356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnGlobalLayoutListener9357;
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener9357, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener9357, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGlobalOnLayoutListener9358;
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener9358, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener9358, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnPreDrawListener9359;
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnPreDrawListener9359, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnPreDrawListener9359, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnPreDrawListener9360;
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnPreDrawListener9360, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnPreDrawListener9360, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnScrollChangedListener9361;
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnScrollChangedListener9361, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnScrollChangedListener9361, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnScrollChangedListener9362;
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnScrollChangedListener9362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnScrollChangedListener9362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnTouchModeChangeListener9363;
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener9363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener9363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnTouchModeChangeListener9364;
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener9364, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener9364, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchOnGlobalLayout9365;
		public void dispatchOnGlobalLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout9365);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout9365);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchOnPreDraw9366;
		public bool dispatchOnPreDraw() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewTreeObserver._dispatchOnPreDraw9366);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnPreDraw9366);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ViewTreeObserver.staticClass = @__class;
			global::android.view.ViewTreeObserver._isAlive9354 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z");
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener9355 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener9356 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener9357 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener9358 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._addOnPreDrawListener9359 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._removeOnPreDrawListener9360 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._addOnScrollChangedListener9361 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener9362 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener9363 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener9364 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout9365 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V");
			global::android.view.ViewTreeObserver._dispatchOnPreDraw9366 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z");
		}
	}
}
