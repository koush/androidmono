namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Toast : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Toast() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Toast), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.Toast(@__env); 
			} 
		} 
		protected Toast(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10424; 
		public virtual void setText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setText10424, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setText10424, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10425; 
		public virtual void setText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setText10425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setText10425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel10426; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _cancel10426); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _cancel10426); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity10427; 
		public virtual void setGravity(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setGravity10427, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setGravity10427, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show10428; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _show10428); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _show10428); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setView10429; 
		public virtual void setView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setView10429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setView10429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView10430; 
		public virtual android.view.View getView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView10430)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Toast.staticClass, _getView10430)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGravity10431; 
		public virtual int getGravity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getGravity10431); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getGravity10431); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuration10432; 
		public virtual void setDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setDuration10432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setDuration10432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration10433; 
		public virtual int getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getDuration10433); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getDuration10433); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMargin10434; 
		public virtual void setMargin(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setMargin10434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setMargin10434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalMargin10435; 
		public virtual float getHorizontalMargin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallFloatMethod(this, _getHorizontalMargin10435); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.Toast.staticClass, _getHorizontalMargin10435); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalMargin10436; 
		public virtual float getVerticalMargin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallFloatMethod(this, _getVerticalMargin10436); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.Toast.staticClass, _getVerticalMargin10436); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXOffset10437; 
		public virtual int getXOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getXOffset10437); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getXOffset10437); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYOffset10438; 
		public virtual int getYOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getYOffset10438); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getYOffset10438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeText10439; 
		public static android.widget.Toast makeText(android.content.Context arg0, java.lang.CharSequence arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Toast>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.Toast.staticClass, _makeText10439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeText10440; 
		public static android.widget.Toast makeText(android.content.Context arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Toast>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.Toast.staticClass, _makeText10440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Toast10441; 
		public Toast(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Toast.staticClass, _Toast10441, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int LENGTH_SHORT
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int LENGTH_LONG
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Toast.staticClass = @__class; 
			global::android.widget.Toast._setText10424 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.Toast._setText10425 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setText", "(I)V"); 
			global::android.widget.Toast._cancel10426 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "cancel", "()V"); 
			global::android.widget.Toast._setGravity10427 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setGravity", "(III)V"); 
			global::android.widget.Toast._show10428 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "show", "()V"); 
			global::android.widget.Toast._setView10429 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setView", "(Landroid/view/View;)V"); 
			global::android.widget.Toast._getView10430 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getView", "()Landroid/view/View;"); 
			global::android.widget.Toast._getGravity10431 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getGravity", "()I"); 
			global::android.widget.Toast._setDuration10432 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setDuration", "(I)V"); 
			global::android.widget.Toast._getDuration10433 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getDuration", "()I"); 
			global::android.widget.Toast._setMargin10434 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setMargin", "(FF)V"); 
			global::android.widget.Toast._getHorizontalMargin10435 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getHorizontalMargin", "()F"); 
			global::android.widget.Toast._getVerticalMargin10436 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getVerticalMargin", "()F"); 
			global::android.widget.Toast._getXOffset10437 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getXOffset", "()I"); 
			global::android.widget.Toast._getYOffset10438 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getYOffset", "()I"); 
			global::android.widget.Toast._makeText10439 = @__env.GetStaticMethodID(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;"); 
			global::android.widget.Toast._makeText10440 = @__env.GetStaticMethodID(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;"); 
			global::android.widget.Toast._Toast10441 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
