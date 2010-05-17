namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{ 
		internal static global::java.lang.Class staticClass; 
		static View() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.View), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.View.BaseSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState7544; 
			public BaseSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.View.BaseSavedState.staticClass, _BaseSavedState7544, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState7545; 
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.View.BaseSavedState.staticClass, _BaseSavedState7545, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR7546; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.BaseSavedState.staticClass = @__class; 
				global::android.view.View.BaseSavedState._BaseSavedState7544 = @__env.GetMethodID(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
				global::android.view.View.BaseSavedState._BaseSavedState7545 = @__env.GetMethodID(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MeasureSpec : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static MeasureSpec() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.View.MeasureSpec), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString7547; 
			public static java.lang.String toString(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.MeasureSpec.staticClass, _toString7547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSize7548; 
			public static int getSize(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, _getSize7548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getMode7549; 
			public static int getMode(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, _getMode7549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _makeMeasureSpec7550; 
			public static int makeMeasureSpec(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, _makeMeasureSpec7550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MeasureSpec7551; 
			public MeasureSpec()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.View.MeasureSpec.staticClass, _MeasureSpec7551, this); 
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
				global::android.view.View.MeasureSpec._toString7547 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;"); 
				global::android.view.View.MeasureSpec._getSize7548 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I"); 
				global::android.view.View.MeasureSpec._getMode7549 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I"); 
				global::android.view.View.MeasureSpec._makeMeasureSpec7550 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I"); 
				global::android.view.View.MeasureSpec._MeasureSpec7551 = @__env.GetMethodID(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnClickListener 
		{ 
			void onClick(android.view.View arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnCreateContextMenuListener 
		{ 
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnFocusChangeListener 
		{ 
			void onFocusChange(android.view.View arg0, bool arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnKeyListener 
		{ 
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnLongClickListener 
		{ 
			bool onLongClick(android.view.View arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTouchListener 
		{ 
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResources7552; 
		public virtual android.content.res.Resources getResources() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, _getResources7552)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getResources7552)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParent7553; 
		public virtual android.view.ViewParent getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, _getParent7553)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getParent7553)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId7554; 
		public virtual int getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getId7554); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getId7554); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext7555; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext7555)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getContext7555)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque7556; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isOpaque7556); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isOpaque7556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHandler7557; 
		public virtual android.os.Handler getHandler() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, _getHandler7557)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getHandler7557)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7558; 
		public static android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.staticClass, _inflate7558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTag7559; 
		public virtual java.lang.Object getTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getTag7559)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getTag7559)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTag7560; 
		public virtual java.lang.Object getTag(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getTag7560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getTag7560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidate7561; 
		public virtual void invalidate(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _invalidate7561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _invalidate7561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidate7562; 
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _invalidate7562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _invalidate7562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidate7563; 
		public virtual void invalidate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _invalidate7563); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _invalidate7563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _layout7564; 
		public virtual void layout(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _layout7564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _layout7564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled7565; 
		public virtual bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isEnabled7565); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isEnabled7565); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled7566; 
		public virtual void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setEnabled7566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setEnabled7566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentDescription7567; 
		public virtual java.lang.CharSequence getContentDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getContentDescription7567)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getContentDescription7567)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentDescription7568; 
		public virtual void setContentDescription(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setContentDescription7568, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setContentDescription7568, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation7569; 
		public virtual android.view.animation.Animation getAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getAnimation7569)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getAnimation7569)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw7570; 
		public virtual void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _draw7570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _draw7570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth7571; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getWidth7571); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getWidth7571); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight7572; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getHeight7572); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getHeight7572); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _post7573; 
		public virtual bool post(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _post7573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _post7573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postDelayed7574; 
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _postDelayed7574, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _postDelayed7574, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks7575; 
		public virtual bool removeCallbacks(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _removeCallbacks7575, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _removeCallbacks7575, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState7576; 
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState7576, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onRestoreInstanceState7576, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState7577; 
		protected virtual android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState7577)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _onSaveInstanceState7577)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById7578; 
		public virtual android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewById7578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _findViewById7578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7579; 
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onKeyDown7579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onKeyDown7579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress7580; 
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onKeyLongPress7580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onKeyLongPress7580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp7581; 
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onKeyUp7581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onKeyUp7581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple7582; 
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple7582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onKeyMultiple7582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent7583; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent7583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onTouchEvent7583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent7584; 
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent7584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onTrackballEvent7584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged7585; 
		public virtual void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged7585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onWindowFocusChanged7585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus7586; 
		public virtual bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _hasFocus7586); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _hasFocus7586); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow7587; 
		protected virtual void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow7587); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onAttachedToWindow7587); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow7588; 
		protected virtual void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow7588); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onDetachedFromWindow7588); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus7589; 
		public virtual bool hasWindowFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _hasWindowFocus7589); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _hasWindowFocus7589); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent7590; 
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent7590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchKeyEvent7590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent7591; 
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchTouchEvent7591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchTouchEvent7591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent7592; 
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchTrackballEvent7592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchTrackballEvent7592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent7593; 
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent7593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchPopulateAccessibilityEvent7593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu7594; 
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onCreateContextMenu7594, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onCreateContextMenu7594, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable7595; 
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setBackgroundDrawable7595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setBackgroundDrawable7595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState7596; 
		public virtual void saveHierarchyState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _saveHierarchyState7596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _saveHierarchyState7596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState7597; 
		public virtual void restoreHierarchyState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _restoreHierarchyState7597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _restoreHierarchyState7597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initializeFadingEdge7598; 
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _initializeFadingEdge7598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _initializeFadingEdge7598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalFadingEdgeLength7599; 
		public virtual int getVerticalFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getVerticalFadingEdgeLength7599); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getVerticalFadingEdgeLength7599); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFadingEdgeLength7600; 
		public virtual void setFadingEdgeLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setFadingEdgeLength7600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setFadingEdgeLength7600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalFadingEdgeLength7601; 
		public virtual int getHorizontalFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getHorizontalFadingEdgeLength7601); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getHorizontalFadingEdgeLength7601); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalScrollbarWidth7602; 
		public virtual int getVerticalScrollbarWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getVerticalScrollbarWidth7602); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getVerticalScrollbarWidth7602); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalScrollbarHeight7603; 
		protected virtual int getHorizontalScrollbarHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getHorizontalScrollbarHeight7603); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getHorizontalScrollbarHeight7603); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initializeScrollbars7604; 
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _initializeScrollbars7604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _initializeScrollbars7604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnFocusChangeListener7605; 
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setOnFocusChangeListener7605, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setOnFocusChangeListener7605, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnFocusChangeListener7606; 
		public virtual android.view.View.OnFocusChangeListener getOnFocusChangeListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.View.OnFocusChangeListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnFocusChangeListener7606)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.View.OnFocusChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getOnFocusChangeListener7606)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener7607; 
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setOnClickListener7607, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setOnClickListener7607, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnLongClickListener7608; 
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setOnLongClickListener7608, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setOnLongClickListener7608, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCreateContextMenuListener7609; 
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setOnCreateContextMenuListener7609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setOnCreateContextMenuListener7609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performClick7610; 
		public virtual bool performClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _performClick7610); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _performClick7610); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick7611; 
		public virtual bool performLongClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _performLongClick7611); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _performLongClick7611); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenu7612; 
		public virtual bool showContextMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _showContextMenu7612); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _showContextMenu7612); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener7613; 
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setOnKeyListener7613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setOnKeyListener7613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnTouchListener7614; 
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setOnTouchListener7614, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setOnTouchListener7614, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRectangleOnScreen7615; 
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _requestRectangleOnScreen7615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _requestRectangleOnScreen7615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRectangleOnScreen7616; 
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _requestRectangleOnScreen7616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _requestRectangleOnScreen7616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFocus7617; 
		public virtual void clearFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _clearFocus7617); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _clearFocus7617); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocusable7618; 
		public virtual bool hasFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _hasFocusable7618); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _hasFocusable7618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged7619; 
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onFocusChanged7619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onFocusChanged7619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEvent7620; 
		public virtual void sendAccessibilityEvent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _sendAccessibilityEvent7620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _sendAccessibilityEvent7620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEventUnchecked7621; 
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _sendAccessibilityEventUnchecked7621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _sendAccessibilityEventUnchecked7621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocused7622; 
		public virtual bool isFocused() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isFocused7622); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isFocused7622); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findFocus7623; 
		public virtual android.view.View findFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findFocus7623)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _findFocus7623)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollContainer7624; 
		public virtual void setScrollContainer(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setScrollContainer7624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setScrollContainer7624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCacheQuality7625; 
		public virtual int getDrawingCacheQuality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getDrawingCacheQuality7625); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getDrawingCacheQuality7625); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheQuality7626; 
		public virtual void setDrawingCacheQuality(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setDrawingCacheQuality7626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setDrawingCacheQuality7626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeepScreenOn7627; 
		public virtual bool getKeepScreenOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _getKeepScreenOn7627); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _getKeepScreenOn7627); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeepScreenOn7628; 
		public virtual void setKeepScreenOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setKeepScreenOn7628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setKeepScreenOn7628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusLeftId7629; 
		public virtual int getNextFocusLeftId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getNextFocusLeftId7629); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getNextFocusLeftId7629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusLeftId7630; 
		public virtual void setNextFocusLeftId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setNextFocusLeftId7630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setNextFocusLeftId7630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusRightId7631; 
		public virtual int getNextFocusRightId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getNextFocusRightId7631); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getNextFocusRightId7631); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusRightId7632; 
		public virtual void setNextFocusRightId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setNextFocusRightId7632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setNextFocusRightId7632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusUpId7633; 
		public virtual int getNextFocusUpId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getNextFocusUpId7633); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getNextFocusUpId7633); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusUpId7634; 
		public virtual void setNextFocusUpId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setNextFocusUpId7634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setNextFocusUpId7634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusDownId7635; 
		public virtual int getNextFocusDownId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getNextFocusDownId7635); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getNextFocusDownId7635); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusDownId7636; 
		public virtual void setNextFocusDownId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setNextFocusDownId7636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setNextFocusDownId7636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShown7637; 
		public virtual bool isShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isShown7637); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isShown7637); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fitSystemWindows7638; 
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _fitSystemWindows7638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _fitSystemWindows7638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVisibility7639; 
		public virtual int getVisibility() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getVisibility7639); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getVisibility7639); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility7640; 
		public virtual void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setVisibility7640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setVisibility7640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable7641; 
		public virtual void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setFocusable7641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setFocusable7641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusableInTouchMode7642; 
		public virtual void setFocusableInTouchMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setFocusableInTouchMode7642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setFocusableInTouchMode7642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoundEffectsEnabled7643; 
		public virtual void setSoundEffectsEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setSoundEffectsEnabled7643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setSoundEffectsEnabled7643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSoundEffectsEnabled7644; 
		public virtual bool isSoundEffectsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isSoundEffectsEnabled7644); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isSoundEffectsEnabled7644); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHapticFeedbackEnabled7645; 
		public virtual void setHapticFeedbackEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setHapticFeedbackEnabled7645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setHapticFeedbackEnabled7645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHapticFeedbackEnabled7646; 
		public virtual bool isHapticFeedbackEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isHapticFeedbackEnabled7646); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isHapticFeedbackEnabled7646); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWillNotDraw7647; 
		public virtual void setWillNotDraw(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setWillNotDraw7647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setWillNotDraw7647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willNotDraw7648; 
		public virtual bool willNotDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _willNotDraw7648); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _willNotDraw7648); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWillNotCacheDrawing7649; 
		public virtual void setWillNotCacheDrawing(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setWillNotCacheDrawing7649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setWillNotCacheDrawing7649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willNotCacheDrawing7650; 
		public virtual bool willNotCacheDrawing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _willNotCacheDrawing7650); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _willNotCacheDrawing7650); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClickable7651; 
		public virtual bool isClickable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isClickable7651); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isClickable7651); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClickable7652; 
		public virtual void setClickable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setClickable7652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setClickable7652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLongClickable7653; 
		public virtual bool isLongClickable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isLongClickable7653); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isLongClickable7653); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLongClickable7654; 
		public virtual void setLongClickable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setLongClickable7654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setLongClickable7654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPressed7655; 
		public virtual void setPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setPressed7655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setPressed7655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed7656; 
		protected virtual void dispatchSetPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchSetPressed7656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchSetPressed7656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPressed7657; 
		public virtual bool isPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isPressed7657); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isPressed7657); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSaveEnabled7658; 
		public virtual bool isSaveEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isSaveEnabled7658); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isSaveEnabled7658); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSaveEnabled7659; 
		public virtual void setSaveEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setSaveEnabled7659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setSaveEnabled7659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocusable7660; 
		public virtual bool isFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isFocusable7660); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isFocusable7660); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocusableInTouchMode7661; 
		public virtual bool isFocusableInTouchMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isFocusableInTouchMode7661); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isFocusableInTouchMode7661); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch7662; 
		public virtual android.view.View focusSearch(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _focusSearch7662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _focusSearch7662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove7663; 
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchUnhandledMove7663, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchUnhandledMove7663, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusables7664; 
		public virtual java.util.ArrayList getFocusables(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getFocusables7664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getFocusables7664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables7665; 
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _addFocusables7665, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _addFocusables7665, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables7666; 
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _addFocusables7666, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _addFocusables7666, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTouchables7667; 
		public virtual java.util.ArrayList getTouchables() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getTouchables7667)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getTouchables7667)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables7668; 
		public virtual void addTouchables(java.util.ArrayList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _addTouchables7668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _addTouchables7668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus7669; 
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _requestFocus7669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _requestFocus7669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus7670; 
		public virtual bool requestFocus(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _requestFocus7670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _requestFocus7670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus7671; 
		public virtual bool requestFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _requestFocus7671); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _requestFocus7671); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocusFromTouch7672; 
		public virtual bool requestFocusFromTouch() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _requestFocusFromTouch7672); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _requestFocusFromTouch7672); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartTemporaryDetach7673; 
		public virtual void onStartTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onStartTemporaryDetach7673); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onStartTemporaryDetach7673); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishTemporaryDetach7674; 
		public virtual void onFinishTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onFinishTemporaryDetach7674); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onFinishTemporaryDetach7674); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyDispatcherState7675; 
		public virtual android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallObjectMethodPtr(this, _getKeyDispatcherState7675)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getKeyDispatcherState7675)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEventPreIme7676; 
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEventPreIme7676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchKeyEventPreIme7676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyShortcutEvent7677; 
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyShortcutEvent7677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _dispatchKeyShortcutEvent7677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged7678; 
		public virtual void dispatchWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchWindowFocusChanged7678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchWindowFocusChanged7678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowVisibilityChanged7679; 
		public virtual void dispatchWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchWindowVisibilityChanged7679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchWindowVisibilityChanged7679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged7680; 
		protected virtual void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onWindowVisibilityChanged7680, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onWindowVisibilityChanged7680, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowVisibility7681; 
		public virtual int getWindowVisibility() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getWindowVisibility7681); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getWindowVisibility7681); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowVisibleDisplayFrame7682; 
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _getWindowVisibleDisplayFrame7682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _getWindowVisibleDisplayFrame7682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInTouchMode7683; 
		public virtual bool isInTouchMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isInTouchMode7683); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isInTouchMode7683); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyPreIme7684; 
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onKeyPreIme7684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onKeyPreIme7684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyShortcut7685; 
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onKeyShortcut7685, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onKeyShortcut7685, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCheckIsTextEditor7686; 
		public virtual bool onCheckIsTextEditor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onCheckIsTextEditor7686); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onCheckIsTextEditor7686); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection7687; 
		public virtual android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, _onCreateInputConnection7687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _onCreateInputConnection7687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkInputConnectionProxy7688; 
		public virtual bool checkInputConnectionProxy(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _checkInputConnectionProxy7688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _checkInputConnectionProxy7688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createContextMenu7689; 
		public virtual void createContextMenu(android.view.ContextMenu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _createContextMenu7689, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _createContextMenu7689, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo7690; 
		protected virtual android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, _getContextMenuInfo7690)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getContextMenuInfo7690)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelLongPress7691; 
		public virtual void cancelLongPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _cancelLongPress7691); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _cancelLongPress7691); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTouchDelegate7692; 
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setTouchDelegate7692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setTouchDelegate7692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTouchDelegate7693; 
		public virtual android.view.TouchDelegate getTouchDelegate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.TouchDelegate>(@__env, @__env.CallObjectMethodPtr(this, _getTouchDelegate7693)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.TouchDelegate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getTouchDelegate7693)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bringToFront7694; 
		public virtual void bringToFront() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _bringToFront7694); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _bringToFront7694); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged7695; 
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onScrollChanged7695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onScrollChanged7695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged7696; 
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onSizeChanged7696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onSizeChanged7696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw7697; 
		protected virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchDraw7697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchDraw7697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollX7698; 
		public virtual int getScrollX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getScrollX7698); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getScrollX7698); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollY7699; 
		public virtual int getScrollY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getScrollY7699); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getScrollY7699); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingRect7700; 
		public virtual void getDrawingRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _getDrawingRect7700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _getDrawingRect7700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMeasuredWidth7701; 
		public virtual int getMeasuredWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getMeasuredWidth7701); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getMeasuredWidth7701); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMeasuredHeight7702; 
		public virtual int getMeasuredHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getMeasuredHeight7702); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getMeasuredHeight7702); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTop7703; 
		public virtual int getTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getTop7703); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getTop7703); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottom7704; 
		public virtual int getBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getBottom7704); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getBottom7704); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeft7705; 
		public virtual int getLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getLeft7705); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getLeft7705); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRight7706; 
		public virtual int getRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getRight7706); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getRight7706); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHitRect7707; 
		public virtual void getHitRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _getHitRect7707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _getHitRect7707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect7708; 
		public virtual void getFocusedRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _getFocusedRect7708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _getFocusedRect7708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalVisibleRect7709; 
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _getGlobalVisibleRect7709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _getGlobalVisibleRect7709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalVisibleRect7710; 
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _getGlobalVisibleRect7710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _getGlobalVisibleRect7710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalVisibleRect7711; 
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _getLocalVisibleRect7711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _getLocalVisibleRect7711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetTopAndBottom7712; 
		public virtual void offsetTopAndBottom(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _offsetTopAndBottom7712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _offsetTopAndBottom7712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetLeftAndRight7713; 
		public virtual void offsetLeftAndRight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _offsetLeftAndRight7713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _offsetLeftAndRight7713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutParams7714; 
		public virtual android.view.ViewGroup.LayoutParams getLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutParams7714)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getLayoutParams7714)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutParams7715; 
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setLayoutParams7715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setLayoutParams7715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo7716; 
		public virtual void scrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _scrollTo7716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _scrollTo7716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollBy7717; 
		public virtual void scrollBy(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _scrollBy7717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _scrollBy7717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars7718; 
		protected virtual bool awakenScrollBars(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _awakenScrollBars7718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _awakenScrollBars7718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars7719; 
		protected virtual bool awakenScrollBars() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _awakenScrollBars7719); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _awakenScrollBars7719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars7720; 
		protected virtual bool awakenScrollBars(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _awakenScrollBars7720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _awakenScrollBars7720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate7721; 
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _postInvalidate7721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _postInvalidate7721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate7722; 
		public virtual void postInvalidate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _postInvalidate7722); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _postInvalidate7722); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidateDelayed7723; 
		public virtual void postInvalidateDelayed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _postInvalidateDelayed7723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _postInvalidateDelayed7723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidateDelayed7724; 
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _postInvalidateDelayed7724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _postInvalidateDelayed7724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll7725; 
		public virtual void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _computeScroll7725); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _computeScroll7725); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontalFadingEdgeEnabled7726; 
		public virtual bool isHorizontalFadingEdgeEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isHorizontalFadingEdgeEnabled7726); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isHorizontalFadingEdgeEnabled7726); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalFadingEdgeEnabled7727; 
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setHorizontalFadingEdgeEnabled7727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setHorizontalFadingEdgeEnabled7727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVerticalFadingEdgeEnabled7728; 
		public virtual bool isVerticalFadingEdgeEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isVerticalFadingEdgeEnabled7728); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isVerticalFadingEdgeEnabled7728); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalFadingEdgeEnabled7729; 
		public virtual void setVerticalFadingEdgeEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setVerticalFadingEdgeEnabled7729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setVerticalFadingEdgeEnabled7729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength7730; 
		protected virtual float getTopFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallFloatMethod(this, _getTopFadingEdgeStrength7730); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.View.staticClass, _getTopFadingEdgeStrength7730); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength7731; 
		protected virtual float getBottomFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallFloatMethod(this, _getBottomFadingEdgeStrength7731); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.View.staticClass, _getBottomFadingEdgeStrength7731); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength7732; 
		protected virtual float getLeftFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallFloatMethod(this, _getLeftFadingEdgeStrength7732); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.View.staticClass, _getLeftFadingEdgeStrength7732); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength7733; 
		protected virtual float getRightFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallFloatMethod(this, _getRightFadingEdgeStrength7733); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.View.staticClass, _getRightFadingEdgeStrength7733); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontalScrollBarEnabled7734; 
		public virtual bool isHorizontalScrollBarEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isHorizontalScrollBarEnabled7734); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isHorizontalScrollBarEnabled7734); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalScrollBarEnabled7735; 
		public virtual void setHorizontalScrollBarEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setHorizontalScrollBarEnabled7735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setHorizontalScrollBarEnabled7735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVerticalScrollBarEnabled7736; 
		public virtual bool isVerticalScrollBarEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isVerticalScrollBarEnabled7736); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isVerticalScrollBarEnabled7736); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalScrollBarEnabled7737; 
		public virtual void setVerticalScrollBarEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setVerticalScrollBarEnabled7737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setVerticalScrollBarEnabled7737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollbarFadingEnabled7738; 
		public virtual void setScrollbarFadingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setScrollbarFadingEnabled7738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setScrollbarFadingEnabled7738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isScrollbarFadingEnabled7739; 
		public virtual bool isScrollbarFadingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isScrollbarFadingEnabled7739); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isScrollbarFadingEnabled7739); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollBarStyle7740; 
		public virtual void setScrollBarStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setScrollBarStyle7740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setScrollBarStyle7740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarStyle7741; 
		public virtual int getScrollBarStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getScrollBarStyle7741); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getScrollBarStyle7741); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange7742; 
		protected virtual int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollRange7742); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _computeHorizontalScrollRange7742); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollOffset7743; 
		protected virtual int computeHorizontalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollOffset7743); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _computeHorizontalScrollOffset7743); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollExtent7744; 
		protected virtual int computeHorizontalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollExtent7744); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _computeHorizontalScrollExtent7744); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange7745; 
		protected virtual int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollRange7745); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _computeVerticalScrollRange7745); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset7746; 
		protected virtual int computeVerticalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollOffset7746); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _computeVerticalScrollOffset7746); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent7747; 
		protected virtual int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollExtent7747); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _computeVerticalScrollExtent7747); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDrawScrollBars7748; 
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onDrawScrollBars7748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onDrawScrollBars7748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw7749; 
		protected virtual void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onDraw7749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onDraw7749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowAttachCount7750; 
		protected virtual int getWindowAttachCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getWindowAttachCount7750); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getWindowAttachCount7750); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowToken7751; 
		public virtual android.os.IBinder getWindowToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getWindowToken7751)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getWindowToken7751)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationWindowToken7752; 
		public virtual android.os.IBinder getApplicationWindowToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getApplicationWindowToken7752)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getApplicationWindowToken7752)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState7753; 
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchSaveInstanceState7753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchSaveInstanceState7753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState7754; 
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState7754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchRestoreInstanceState7754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingTime7755; 
		public virtual long getDrawingTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallLongMethod(this, _getDrawingTime7755); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.View.staticClass, _getDrawingTime7755); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuplicateParentStateEnabled7756; 
		public virtual void setDuplicateParentStateEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setDuplicateParentStateEnabled7756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setDuplicateParentStateEnabled7756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDuplicateParentStateEnabled7757; 
		public virtual bool isDuplicateParentStateEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isDuplicateParentStateEnabled7757); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isDuplicateParentStateEnabled7757); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheEnabled7758; 
		public virtual void setDrawingCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setDrawingCacheEnabled7758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setDrawingCacheEnabled7758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDrawingCacheEnabled7759; 
		public virtual bool isDrawingCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isDrawingCacheEnabled7759); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isDrawingCacheEnabled7759); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCache7760; 
		public virtual android.graphics.Bitmap getDrawingCache(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _getDrawingCache7760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getDrawingCache7760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCache7761; 
		public virtual android.graphics.Bitmap getDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _getDrawingCache7761)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getDrawingCache7761)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroyDrawingCache7762; 
		public virtual void destroyDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _destroyDrawingCache7762); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _destroyDrawingCache7762); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheBackgroundColor7763; 
		public virtual void setDrawingCacheBackgroundColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setDrawingCacheBackgroundColor7763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setDrawingCacheBackgroundColor7763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCacheBackgroundColor7764; 
		public virtual int getDrawingCacheBackgroundColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getDrawingCacheBackgroundColor7764); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getDrawingCacheBackgroundColor7764); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _buildDrawingCache7765; 
		public virtual void buildDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _buildDrawingCache7765); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _buildDrawingCache7765); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _buildDrawingCache7766; 
		public virtual void buildDrawingCache(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _buildDrawingCache7766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _buildDrawingCache7766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInEditMode7767; 
		public virtual bool isInEditMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isInEditMode7767); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isInEditMode7767); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPaddingOffsetRequired7768; 
		protected virtual bool isPaddingOffsetRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isPaddingOffsetRequired7768); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isPaddingOffsetRequired7768); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftPaddingOffset7769; 
		protected virtual int getLeftPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getLeftPaddingOffset7769); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getLeftPaddingOffset7769); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightPaddingOffset7770; 
		protected virtual int getRightPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getRightPaddingOffset7770); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getRightPaddingOffset7770); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPaddingOffset7771; 
		protected virtual int getTopPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getTopPaddingOffset7771); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getTopPaddingOffset7771); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPaddingOffset7772; 
		protected virtual int getBottomPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getBottomPaddingOffset7772); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getBottomPaddingOffset7772); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSolidColor7773; 
		public virtual int getSolidColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getSolidColor7773); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getSolidColor7773); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLayoutRequested7774; 
		public virtual bool isLayoutRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isLayoutRequested7774); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isLayoutRequested7774); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout7775; 
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onLayout7775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onLayout7775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate7776; 
		protected virtual void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onFinishInflate7776); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onFinishInflate7776); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable7777; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _invalidateDrawable7777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _invalidateDrawable7777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable7778; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _scheduleDrawable7778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _scheduleDrawable7778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable7779; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable7779, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _unscheduleDrawable7779, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable7780; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable7780, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _unscheduleDrawable7780, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable7781; 
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable7781, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _verifyDrawable7781, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged7782; 
		protected virtual void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _drawableStateChanged7782); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _drawableStateChanged7782); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _refreshDrawableState7783; 
		public virtual void refreshDrawableState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _refreshDrawableState7783); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _refreshDrawableState7783); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawableState7784; 
		public virtual int[] getDrawableState() 
		{ 
			if (GetType() == typeof(android.view.View)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getDrawableState7784)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getDrawableState7784)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState7785; 
		protected virtual int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.view.View)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _onCreateDrawableState7785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _onCreateDrawableState7785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mergeDrawableStates7786; 
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.staticClass, _mergeDrawableStates7786, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundColor7787; 
		public virtual void setBackgroundColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setBackgroundColor7787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setBackgroundColor7787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundResource7788; 
		public virtual void setBackgroundResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setBackgroundResource7788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setBackgroundResource7788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackground7789; 
		public virtual android.graphics.drawable.Drawable getBackground() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getBackground7789)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getBackground7789)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding7790; 
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setPadding7790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setPadding7790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingTop7791; 
		public virtual int getPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getPaddingTop7791); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getPaddingTop7791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingBottom7792; 
		public virtual int getPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getPaddingBottom7792); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getPaddingBottom7792); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingLeft7793; 
		public virtual int getPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getPaddingLeft7793); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getPaddingLeft7793); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingRight7794; 
		public virtual int getPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getPaddingRight7794); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getPaddingRight7794); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelected7795; 
		public virtual void setSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setSelected7795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setSelected7795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected7796; 
		protected virtual void dispatchSetSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _dispatchSetSelected7796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _dispatchSetSelected7796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSelected7797; 
		public virtual bool isSelected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _isSelected7797); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _isSelected7797); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTreeObserver7798; 
		public virtual android.view.ViewTreeObserver getViewTreeObserver() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewTreeObserver>(@__env, @__env.CallObjectMethodPtr(this, _getViewTreeObserver7798)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewTreeObserver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getViewTreeObserver7798)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRootView7799; 
		public virtual android.view.View getRootView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getRootView7799)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _getRootView7799)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocationOnScreen7800; 
		public virtual void getLocationOnScreen(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _getLocationOnScreen7800, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _getLocationOnScreen7800, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocationInWindow7801; 
		public virtual void getLocationInWindow(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _getLocationInWindow7801, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _getLocationInWindow7801, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewWithTag7802; 
		public virtual android.view.View findViewWithTag(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewWithTag7802, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.View.staticClass, _findViewWithTag7802, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setId7803; 
		public virtual void setId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setId7803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setId7803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTag7804; 
		public virtual void setTag(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setTag7804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setTag7804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTag7805; 
		public virtual void setTag(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setTag7805, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setTag7805, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline7806; 
		public virtual int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getBaseline7806); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getBaseline7806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout7807; 
		public virtual void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _requestLayout7807); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _requestLayout7807); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _forceLayout7808; 
		public virtual void forceLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _forceLayout7808); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _forceLayout7808); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measure7809; 
		public virtual void measure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _measure7809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _measure7809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure7810; 
		protected virtual void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onMeasure7810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onMeasure7810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMeasuredDimension7811; 
		protected virtual void setMeasuredDimension(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setMeasuredDimension7811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setMeasuredDimension7811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveSize7812; 
		public static int resolveSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.View.staticClass, _resolveSize7812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultSize7813; 
		public static int getDefaultSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.View.staticClass, _getDefaultSize7813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestedMinimumHeight7814; 
		protected virtual int getSuggestedMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getSuggestedMinimumHeight7814); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getSuggestedMinimumHeight7814); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestedMinimumWidth7815; 
		protected virtual int getSuggestedMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallIntMethod(this, _getSuggestedMinimumWidth7815); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.View.staticClass, _getSuggestedMinimumWidth7815); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumHeight7816; 
		public virtual void setMinimumHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setMinimumHeight7816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setMinimumHeight7816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumWidth7817; 
		public virtual void setMinimumWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setMinimumWidth7817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setMinimumWidth7817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startAnimation7818; 
		public virtual void startAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _startAnimation7818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _startAnimation7818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAnimation7819; 
		public virtual void clearAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _clearAnimation7819); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _clearAnimation7819); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation7820; 
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _setAnimation7820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _setAnimation7820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart7821; 
		protected virtual void onAnimationStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onAnimationStart7821); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onAnimationStart7821); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd7822; 
		protected virtual void onAnimationEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _onAnimationEnd7822); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _onAnimationEnd7822); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetAlpha7823; 
		protected virtual bool onSetAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _onSetAlpha7823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _onSetAlpha7823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect7824; 
		public virtual void playSoundEffect(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				@__env.CallVoidMethod(this, _playSoundEffect7824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.View.staticClass, _playSoundEffect7824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performHapticFeedback7825; 
		public virtual bool performHapticFeedback(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _performHapticFeedback7825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _performHapticFeedback7825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performHapticFeedback7826; 
		public virtual bool performHapticFeedback(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.View)) 
				return @__env.CallBooleanMethod(this, _performHapticFeedback7826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.View.staticClass, _performHapticFeedback7826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _View7827; 
		public View(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.View.staticClass, _View7827, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _View7828; 
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.View.staticClass, _View7828, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _View7829; 
		public View(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.View.staticClass, _View7829, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.view.View._getResources7552 = @__env.GetMethodID(global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.view.View._getParent7553 = @__env.GetMethodID(global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;"); 
			global::android.view.View._getId7554 = @__env.GetMethodID(global::android.view.View.staticClass, "getId", "()I"); 
			global::android.view.View._getContext7555 = @__env.GetMethodID(global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.view.View._isOpaque7556 = @__env.GetMethodID(global::android.view.View.staticClass, "isOpaque", "()Z"); 
			global::android.view.View._getHandler7557 = @__env.GetMethodID(global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;"); 
			global::android.view.View._inflate7558 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.view.View._getTag7559 = @__env.GetMethodID(global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;"); 
			global::android.view.View._getTag7560 = @__env.GetMethodID(global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;"); 
			global::android.view.View._invalidate7561 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._invalidate7562 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "(IIII)V"); 
			global::android.view.View._invalidate7563 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "()V"); 
			global::android.view.View._layout7564 = @__env.GetMethodID(global::android.view.View.staticClass, "layout", "(IIII)V"); 
			global::android.view.View._isEnabled7565 = @__env.GetMethodID(global::android.view.View.staticClass, "isEnabled", "()Z"); 
			global::android.view.View._setEnabled7566 = @__env.GetMethodID(global::android.view.View.staticClass, "setEnabled", "(Z)V"); 
			global::android.view.View._getContentDescription7567 = @__env.GetMethodID(global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;"); 
			global::android.view.View._setContentDescription7568 = @__env.GetMethodID(global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.View._getAnimation7569 = @__env.GetMethodID(global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.view.View._draw7570 = @__env.GetMethodID(global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._getWidth7571 = @__env.GetMethodID(global::android.view.View.staticClass, "getWidth", "()I"); 
			global::android.view.View._getHeight7572 = @__env.GetMethodID(global::android.view.View.staticClass, "getHeight", "()I"); 
			global::android.view.View._post7573 = @__env.GetMethodID(global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z"); 
			global::android.view.View._postDelayed7574 = @__env.GetMethodID(global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z"); 
			global::android.view.View._removeCallbacks7575 = @__env.GetMethodID(global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z"); 
			global::android.view.View._onRestoreInstanceState7576 = @__env.GetMethodID(global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.view.View._onSaveInstanceState7577 = @__env.GetMethodID(global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.view.View._findViewById7578 = @__env.GetMethodID(global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.view.View._onKeyDown7579 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyLongPress7580 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyUp7581 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyMultiple7582 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onTouchEvent7583 = @__env.GetMethodID(global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._onTrackballEvent7584 = @__env.GetMethodID(global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._onWindowFocusChanged7585 = @__env.GetMethodID(global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.view.View._hasFocus7586 = @__env.GetMethodID(global::android.view.View.staticClass, "hasFocus", "()Z"); 
			global::android.view.View._onAttachedToWindow7587 = @__env.GetMethodID(global::android.view.View.staticClass, "onAttachedToWindow", "()V"); 
			global::android.view.View._onDetachedFromWindow7588 = @__env.GetMethodID(global::android.view.View.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.view.View._hasWindowFocus7589 = @__env.GetMethodID(global::android.view.View.staticClass, "hasWindowFocus", "()Z"); 
			global::android.view.View._dispatchKeyEvent7590 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.View._dispatchTouchEvent7591 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._dispatchTrackballEvent7592 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._dispatchPopulateAccessibilityEvent7593 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.view.View._onCreateContextMenu7594 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V"); 
			global::android.view.View._setBackgroundDrawable7595 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.View._saveHierarchyState7596 = @__env.GetMethodID(global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._restoreHierarchyState7597 = @__env.GetMethodID(global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._initializeFadingEdge7598 = @__env.GetMethodID(global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V"); 
			global::android.view.View._getVerticalFadingEdgeLength7599 = @__env.GetMethodID(global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I"); 
			global::android.view.View._setFadingEdgeLength7600 = @__env.GetMethodID(global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V"); 
			global::android.view.View._getHorizontalFadingEdgeLength7601 = @__env.GetMethodID(global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I"); 
			global::android.view.View._getVerticalScrollbarWidth7602 = @__env.GetMethodID(global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I"); 
			global::android.view.View._getHorizontalScrollbarHeight7603 = @__env.GetMethodID(global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I"); 
			global::android.view.View._initializeScrollbars7604 = @__env.GetMethodID(global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V"); 
			global::android.view.View._setOnFocusChangeListener7605 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V"); 
			global::android.view.View._getOnFocusChangeListener7606 = @__env.GetMethodID(global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;"); 
			global::android.view.View._setOnClickListener7607 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.view.View._setOnLongClickListener7608 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V"); 
			global::android.view.View._setOnCreateContextMenuListener7609 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V"); 
			global::android.view.View._performClick7610 = @__env.GetMethodID(global::android.view.View.staticClass, "performClick", "()Z"); 
			global::android.view.View._performLongClick7611 = @__env.GetMethodID(global::android.view.View.staticClass, "performLongClick", "()Z"); 
			global::android.view.View._showContextMenu7612 = @__env.GetMethodID(global::android.view.View.staticClass, "showContextMenu", "()Z"); 
			global::android.view.View._setOnKeyListener7613 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V"); 
			global::android.view.View._setOnTouchListener7614 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V"); 
			global::android.view.View._requestRectangleOnScreen7615 = @__env.GetMethodID(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._requestRectangleOnScreen7616 = @__env.GetMethodID(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z"); 
			global::android.view.View._clearFocus7617 = @__env.GetMethodID(global::android.view.View.staticClass, "clearFocus", "()V"); 
			global::android.view.View._hasFocusable7618 = @__env.GetMethodID(global::android.view.View.staticClass, "hasFocusable", "()Z"); 
			global::android.view.View._onFocusChanged7619 = @__env.GetMethodID(global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.view.View._sendAccessibilityEvent7620 = @__env.GetMethodID(global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V"); 
			global::android.view.View._sendAccessibilityEventUnchecked7621 = @__env.GetMethodID(global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V"); 
			global::android.view.View._isFocused7622 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocused", "()Z"); 
			global::android.view.View._findFocus7623 = @__env.GetMethodID(global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;"); 
			global::android.view.View._setScrollContainer7624 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollContainer", "(Z)V"); 
			global::android.view.View._getDrawingCacheQuality7625 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCacheQuality", "()I"); 
			global::android.view.View._setDrawingCacheQuality7626 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V"); 
			global::android.view.View._getKeepScreenOn7627 = @__env.GetMethodID(global::android.view.View.staticClass, "getKeepScreenOn", "()Z"); 
			global::android.view.View._setKeepScreenOn7628 = @__env.GetMethodID(global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V"); 
			global::android.view.View._getNextFocusLeftId7629 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusLeftId", "()I"); 
			global::android.view.View._setNextFocusLeftId7630 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V"); 
			global::android.view.View._getNextFocusRightId7631 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusRightId", "()I"); 
			global::android.view.View._setNextFocusRightId7632 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusRightId", "(I)V"); 
			global::android.view.View._getNextFocusUpId7633 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusUpId", "()I"); 
			global::android.view.View._setNextFocusUpId7634 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusUpId", "(I)V"); 
			global::android.view.View._getNextFocusDownId7635 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusDownId", "()I"); 
			global::android.view.View._setNextFocusDownId7636 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusDownId", "(I)V"); 
			global::android.view.View._isShown7637 = @__env.GetMethodID(global::android.view.View.staticClass, "isShown", "()Z"); 
			global::android.view.View._fitSystemWindows7638 = @__env.GetMethodID(global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._getVisibility7639 = @__env.GetMethodID(global::android.view.View.staticClass, "getVisibility", "()I"); 
			global::android.view.View._setVisibility7640 = @__env.GetMethodID(global::android.view.View.staticClass, "setVisibility", "(I)V"); 
			global::android.view.View._setFocusable7641 = @__env.GetMethodID(global::android.view.View.staticClass, "setFocusable", "(Z)V"); 
			global::android.view.View._setFocusableInTouchMode7642 = @__env.GetMethodID(global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V"); 
			global::android.view.View._setSoundEffectsEnabled7643 = @__env.GetMethodID(global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V"); 
			global::android.view.View._isSoundEffectsEnabled7644 = @__env.GetMethodID(global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z"); 
			global::android.view.View._setHapticFeedbackEnabled7645 = @__env.GetMethodID(global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V"); 
			global::android.view.View._isHapticFeedbackEnabled7646 = @__env.GetMethodID(global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z"); 
			global::android.view.View._setWillNotDraw7647 = @__env.GetMethodID(global::android.view.View.staticClass, "setWillNotDraw", "(Z)V"); 
			global::android.view.View._willNotDraw7648 = @__env.GetMethodID(global::android.view.View.staticClass, "willNotDraw", "()Z"); 
			global::android.view.View._setWillNotCacheDrawing7649 = @__env.GetMethodID(global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V"); 
			global::android.view.View._willNotCacheDrawing7650 = @__env.GetMethodID(global::android.view.View.staticClass, "willNotCacheDrawing", "()Z"); 
			global::android.view.View._isClickable7651 = @__env.GetMethodID(global::android.view.View.staticClass, "isClickable", "()Z"); 
			global::android.view.View._setClickable7652 = @__env.GetMethodID(global::android.view.View.staticClass, "setClickable", "(Z)V"); 
			global::android.view.View._isLongClickable7653 = @__env.GetMethodID(global::android.view.View.staticClass, "isLongClickable", "()Z"); 
			global::android.view.View._setLongClickable7654 = @__env.GetMethodID(global::android.view.View.staticClass, "setLongClickable", "(Z)V"); 
			global::android.view.View._setPressed7655 = @__env.GetMethodID(global::android.view.View.staticClass, "setPressed", "(Z)V"); 
			global::android.view.View._dispatchSetPressed7656 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V"); 
			global::android.view.View._isPressed7657 = @__env.GetMethodID(global::android.view.View.staticClass, "isPressed", "()Z"); 
			global::android.view.View._isSaveEnabled7658 = @__env.GetMethodID(global::android.view.View.staticClass, "isSaveEnabled", "()Z"); 
			global::android.view.View._setSaveEnabled7659 = @__env.GetMethodID(global::android.view.View.staticClass, "setSaveEnabled", "(Z)V"); 
			global::android.view.View._isFocusable7660 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocusable", "()Z"); 
			global::android.view.View._isFocusableInTouchMode7661 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z"); 
			global::android.view.View._focusSearch7662 = @__env.GetMethodID(global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;"); 
			global::android.view.View._dispatchUnhandledMove7663 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z"); 
			global::android.view.View._getFocusables7664 = @__env.GetMethodID(global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;"); 
			global::android.view.View._addFocusables7665 = @__env.GetMethodID(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V"); 
			global::android.view.View._addFocusables7666 = @__env.GetMethodID(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V"); 
			global::android.view.View._getTouchables7667 = @__env.GetMethodID(global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;"); 
			global::android.view.View._addTouchables7668 = @__env.GetMethodID(global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V"); 
			global::android.view.View._requestFocus7669 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z"); 
			global::android.view.View._requestFocus7670 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "(I)Z"); 
			global::android.view.View._requestFocus7671 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "()Z"); 
			global::android.view.View._requestFocusFromTouch7672 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocusFromTouch", "()Z"); 
			global::android.view.View._onStartTemporaryDetach7673 = @__env.GetMethodID(global::android.view.View.staticClass, "onStartTemporaryDetach", "()V"); 
			global::android.view.View._onFinishTemporaryDetach7674 = @__env.GetMethodID(global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V"); 
			global::android.view.View._getKeyDispatcherState7675 = @__env.GetMethodID(global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;"); 
			global::android.view.View._dispatchKeyEventPreIme7676 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.View._dispatchKeyShortcutEvent7677 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.View._dispatchWindowFocusChanged7678 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V"); 
			global::android.view.View._dispatchWindowVisibilityChanged7679 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V"); 
			global::android.view.View._onWindowVisibilityChanged7680 = @__env.GetMethodID(global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.view.View._getWindowVisibility7681 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowVisibility", "()I"); 
			global::android.view.View._getWindowVisibleDisplayFrame7682 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._isInTouchMode7683 = @__env.GetMethodID(global::android.view.View.staticClass, "isInTouchMode", "()Z"); 
			global::android.view.View._onKeyPreIme7684 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyShortcut7685 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onCheckIsTextEditor7686 = @__env.GetMethodID(global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z"); 
			global::android.view.View._onCreateInputConnection7687 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;"); 
			global::android.view.View._checkInputConnectionProxy7688 = @__env.GetMethodID(global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z"); 
			global::android.view.View._createContextMenu7689 = @__env.GetMethodID(global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V"); 
			global::android.view.View._getContextMenuInfo7690 = @__env.GetMethodID(global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;"); 
			global::android.view.View._cancelLongPress7691 = @__env.GetMethodID(global::android.view.View.staticClass, "cancelLongPress", "()V"); 
			global::android.view.View._setTouchDelegate7692 = @__env.GetMethodID(global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V"); 
			global::android.view.View._getTouchDelegate7693 = @__env.GetMethodID(global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;"); 
			global::android.view.View._bringToFront7694 = @__env.GetMethodID(global::android.view.View.staticClass, "bringToFront", "()V"); 
			global::android.view.View._onScrollChanged7695 = @__env.GetMethodID(global::android.view.View.staticClass, "onScrollChanged", "(IIII)V"); 
			global::android.view.View._onSizeChanged7696 = @__env.GetMethodID(global::android.view.View.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.view.View._dispatchDraw7697 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._getScrollX7698 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollX", "()I"); 
			global::android.view.View._getScrollY7699 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollY", "()I"); 
			global::android.view.View._getDrawingRect7700 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._getMeasuredWidth7701 = @__env.GetMethodID(global::android.view.View.staticClass, "getMeasuredWidth", "()I"); 
			global::android.view.View._getMeasuredHeight7702 = @__env.GetMethodID(global::android.view.View.staticClass, "getMeasuredHeight", "()I"); 
			global::android.view.View._getTop7703 = @__env.GetMethodID(global::android.view.View.staticClass, "getTop", "()I"); 
			global::android.view.View._getBottom7704 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottom", "()I"); 
			global::android.view.View._getLeft7705 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeft", "()I"); 
			global::android.view.View._getRight7706 = @__env.GetMethodID(global::android.view.View.staticClass, "getRight", "()I"); 
			global::android.view.View._getHitRect7707 = @__env.GetMethodID(global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._getFocusedRect7708 = @__env.GetMethodID(global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._getGlobalVisibleRect7709 = @__env.GetMethodID(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._getGlobalVisibleRect7710 = @__env.GetMethodID(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z"); 
			global::android.view.View._getLocalVisibleRect7711 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._offsetTopAndBottom7712 = @__env.GetMethodID(global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V"); 
			global::android.view.View._offsetLeftAndRight7713 = @__env.GetMethodID(global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V"); 
			global::android.view.View._getLayoutParams7714 = @__env.GetMethodID(global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.View._setLayoutParams7715 = @__env.GetMethodID(global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.View._scrollTo7716 = @__env.GetMethodID(global::android.view.View.staticClass, "scrollTo", "(II)V"); 
			global::android.view.View._scrollBy7717 = @__env.GetMethodID(global::android.view.View.staticClass, "scrollBy", "(II)V"); 
			global::android.view.View._awakenScrollBars7718 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "(I)Z"); 
			global::android.view.View._awakenScrollBars7719 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "()Z"); 
			global::android.view.View._awakenScrollBars7720 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z"); 
			global::android.view.View._postInvalidate7721 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidate", "(IIII)V"); 
			global::android.view.View._postInvalidate7722 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidate", "()V"); 
			global::android.view.View._postInvalidateDelayed7723 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V"); 
			global::android.view.View._postInvalidateDelayed7724 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V"); 
			global::android.view.View._computeScroll7725 = @__env.GetMethodID(global::android.view.View.staticClass, "computeScroll", "()V"); 
			global::android.view.View._isHorizontalFadingEdgeEnabled7726 = @__env.GetMethodID(global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z"); 
			global::android.view.View._setHorizontalFadingEdgeEnabled7727 = @__env.GetMethodID(global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V"); 
			global::android.view.View._isVerticalFadingEdgeEnabled7728 = @__env.GetMethodID(global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z"); 
			global::android.view.View._setVerticalFadingEdgeEnabled7729 = @__env.GetMethodID(global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V"); 
			global::android.view.View._getTopFadingEdgeStrength7730 = @__env.GetMethodID(global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F"); 
			global::android.view.View._getBottomFadingEdgeStrength7731 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F"); 
			global::android.view.View._getLeftFadingEdgeStrength7732 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F"); 
			global::android.view.View._getRightFadingEdgeStrength7733 = @__env.GetMethodID(global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F"); 
			global::android.view.View._isHorizontalScrollBarEnabled7734 = @__env.GetMethodID(global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z"); 
			global::android.view.View._setHorizontalScrollBarEnabled7735 = @__env.GetMethodID(global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V"); 
			global::android.view.View._isVerticalScrollBarEnabled7736 = @__env.GetMethodID(global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z"); 
			global::android.view.View._setVerticalScrollBarEnabled7737 = @__env.GetMethodID(global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V"); 
			global::android.view.View._setScrollbarFadingEnabled7738 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V"); 
			global::android.view.View._isScrollbarFadingEnabled7739 = @__env.GetMethodID(global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z"); 
			global::android.view.View._setScrollBarStyle7740 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollBarStyle", "(I)V"); 
			global::android.view.View._getScrollBarStyle7741 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollBarStyle", "()I"); 
			global::android.view.View._computeHorizontalScrollRange7742 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.view.View._computeHorizontalScrollOffset7743 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I"); 
			global::android.view.View._computeHorizontalScrollExtent7744 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I"); 
			global::android.view.View._computeVerticalScrollRange7745 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.view.View._computeVerticalScrollOffset7746 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I"); 
			global::android.view.View._computeVerticalScrollExtent7747 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.view.View._onDrawScrollBars7748 = @__env.GetMethodID(global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._onDraw7749 = @__env.GetMethodID(global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._getWindowAttachCount7750 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowAttachCount", "()I"); 
			global::android.view.View._getWindowToken7751 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;"); 
			global::android.view.View._getApplicationWindowToken7752 = @__env.GetMethodID(global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;"); 
			global::android.view.View._dispatchSaveInstanceState7753 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._dispatchRestoreInstanceState7754 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._getDrawingTime7755 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingTime", "()J"); 
			global::android.view.View._setDuplicateParentStateEnabled7756 = @__env.GetMethodID(global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V"); 
			global::android.view.View._isDuplicateParentStateEnabled7757 = @__env.GetMethodID(global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z"); 
			global::android.view.View._setDrawingCacheEnabled7758 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V"); 
			global::android.view.View._isDrawingCacheEnabled7759 = @__env.GetMethodID(global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z"); 
			global::android.view.View._getDrawingCache7760 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;"); 
			global::android.view.View._getDrawingCache7761 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;"); 
			global::android.view.View._destroyDrawingCache7762 = @__env.GetMethodID(global::android.view.View.staticClass, "destroyDrawingCache", "()V"); 
			global::android.view.View._setDrawingCacheBackgroundColor7763 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V"); 
			global::android.view.View._getDrawingCacheBackgroundColor7764 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I"); 
			global::android.view.View._buildDrawingCache7765 = @__env.GetMethodID(global::android.view.View.staticClass, "buildDrawingCache", "()V"); 
			global::android.view.View._buildDrawingCache7766 = @__env.GetMethodID(global::android.view.View.staticClass, "buildDrawingCache", "(Z)V"); 
			global::android.view.View._isInEditMode7767 = @__env.GetMethodID(global::android.view.View.staticClass, "isInEditMode", "()Z"); 
			global::android.view.View._isPaddingOffsetRequired7768 = @__env.GetMethodID(global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z"); 
			global::android.view.View._getLeftPaddingOffset7769 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeftPaddingOffset", "()I"); 
			global::android.view.View._getRightPaddingOffset7770 = @__env.GetMethodID(global::android.view.View.staticClass, "getRightPaddingOffset", "()I"); 
			global::android.view.View._getTopPaddingOffset7771 = @__env.GetMethodID(global::android.view.View.staticClass, "getTopPaddingOffset", "()I"); 
			global::android.view.View._getBottomPaddingOffset7772 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottomPaddingOffset", "()I"); 
			global::android.view.View._getSolidColor7773 = @__env.GetMethodID(global::android.view.View.staticClass, "getSolidColor", "()I"); 
			global::android.view.View._isLayoutRequested7774 = @__env.GetMethodID(global::android.view.View.staticClass, "isLayoutRequested", "()Z"); 
			global::android.view.View._onLayout7775 = @__env.GetMethodID(global::android.view.View.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.view.View._onFinishInflate7776 = @__env.GetMethodID(global::android.view.View.staticClass, "onFinishInflate", "()V"); 
			global::android.view.View._invalidateDrawable7777 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.View._scheduleDrawable7778 = @__env.GetMethodID(global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.view.View._unscheduleDrawable7779 = @__env.GetMethodID(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.view.View._unscheduleDrawable7780 = @__env.GetMethodID(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.View._verifyDrawable7781 = @__env.GetMethodID(global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.view.View._drawableStateChanged7782 = @__env.GetMethodID(global::android.view.View.staticClass, "drawableStateChanged", "()V"); 
			global::android.view.View._refreshDrawableState7783 = @__env.GetMethodID(global::android.view.View.staticClass, "refreshDrawableState", "()V"); 
			global::android.view.View._getDrawableState7784 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawableState", "()[I"); 
			global::android.view.View._onCreateDrawableState7785 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.view.View._mergeDrawableStates7786 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I"); 
			global::android.view.View._setBackgroundColor7787 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundColor", "(I)V"); 
			global::android.view.View._setBackgroundResource7788 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundResource", "(I)V"); 
			global::android.view.View._getBackground7789 = @__env.GetMethodID(global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.view.View._setPadding7790 = @__env.GetMethodID(global::android.view.View.staticClass, "setPadding", "(IIII)V"); 
			global::android.view.View._getPaddingTop7791 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingTop", "()I"); 
			global::android.view.View._getPaddingBottom7792 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingBottom", "()I"); 
			global::android.view.View._getPaddingLeft7793 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingLeft", "()I"); 
			global::android.view.View._getPaddingRight7794 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingRight", "()I"); 
			global::android.view.View._setSelected7795 = @__env.GetMethodID(global::android.view.View.staticClass, "setSelected", "(Z)V"); 
			global::android.view.View._dispatchSetSelected7796 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V"); 
			global::android.view.View._isSelected7797 = @__env.GetMethodID(global::android.view.View.staticClass, "isSelected", "()Z"); 
			global::android.view.View._getViewTreeObserver7798 = @__env.GetMethodID(global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;"); 
			global::android.view.View._getRootView7799 = @__env.GetMethodID(global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;"); 
			global::android.view.View._getLocationOnScreen7800 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocationOnScreen", "([I)V"); 
			global::android.view.View._getLocationInWindow7801 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocationInWindow", "([I)V"); 
			global::android.view.View._findViewWithTag7802 = @__env.GetMethodID(global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;"); 
			global::android.view.View._setId7803 = @__env.GetMethodID(global::android.view.View.staticClass, "setId", "(I)V"); 
			global::android.view.View._setTag7804 = @__env.GetMethodID(global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V"); 
			global::android.view.View._setTag7805 = @__env.GetMethodID(global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V"); 
			global::android.view.View._getBaseline7806 = @__env.GetMethodID(global::android.view.View.staticClass, "getBaseline", "()I"); 
			global::android.view.View._requestLayout7807 = @__env.GetMethodID(global::android.view.View.staticClass, "requestLayout", "()V"); 
			global::android.view.View._forceLayout7808 = @__env.GetMethodID(global::android.view.View.staticClass, "forceLayout", "()V"); 
			global::android.view.View._measure7809 = @__env.GetMethodID(global::android.view.View.staticClass, "measure", "(II)V"); 
			global::android.view.View._onMeasure7810 = @__env.GetMethodID(global::android.view.View.staticClass, "onMeasure", "(II)V"); 
			global::android.view.View._setMeasuredDimension7811 = @__env.GetMethodID(global::android.view.View.staticClass, "setMeasuredDimension", "(II)V"); 
			global::android.view.View._resolveSize7812 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "resolveSize", "(II)I"); 
			global::android.view.View._getDefaultSize7813 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "getDefaultSize", "(II)I"); 
			global::android.view.View._getSuggestedMinimumHeight7814 = @__env.GetMethodID(global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I"); 
			global::android.view.View._getSuggestedMinimumWidth7815 = @__env.GetMethodID(global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I"); 
			global::android.view.View._setMinimumHeight7816 = @__env.GetMethodID(global::android.view.View.staticClass, "setMinimumHeight", "(I)V"); 
			global::android.view.View._setMinimumWidth7817 = @__env.GetMethodID(global::android.view.View.staticClass, "setMinimumWidth", "(I)V"); 
			global::android.view.View._startAnimation7818 = @__env.GetMethodID(global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.View._clearAnimation7819 = @__env.GetMethodID(global::android.view.View.staticClass, "clearAnimation", "()V"); 
			global::android.view.View._setAnimation7820 = @__env.GetMethodID(global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.View._onAnimationStart7821 = @__env.GetMethodID(global::android.view.View.staticClass, "onAnimationStart", "()V"); 
			global::android.view.View._onAnimationEnd7822 = @__env.GetMethodID(global::android.view.View.staticClass, "onAnimationEnd", "()V"); 
			global::android.view.View._onSetAlpha7823 = @__env.GetMethodID(global::android.view.View.staticClass, "onSetAlpha", "(I)Z"); 
			global::android.view.View._playSoundEffect7824 = @__env.GetMethodID(global::android.view.View.staticClass, "playSoundEffect", "(I)V"); 
			global::android.view.View._performHapticFeedback7825 = @__env.GetMethodID(global::android.view.View.staticClass, "performHapticFeedback", "(I)Z"); 
			global::android.view.View._performHapticFeedback7826 = @__env.GetMethodID(global::android.view.View.staticClass, "performHapticFeedback", "(II)Z"); 
			global::android.view.View._View7827 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.view.View._View7828 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.view.View._View7829 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
