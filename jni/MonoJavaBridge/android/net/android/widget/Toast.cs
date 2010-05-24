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
		internal static global::net.sf.jni4net.jni.MethodId _setText11229; 
		public virtual void setText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setText11229, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setText11229, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText11230; 
		public virtual void setText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setText11230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setText11230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel11231; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _cancel11231); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _cancel11231); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity11232; 
		public virtual void setGravity(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setGravity11232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setGravity11232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show11233; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _show11233); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _show11233); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setView11234; 
		public virtual void setView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setView11234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setView11234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView11235; 
		public virtual android.view.View getView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView11235)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Toast.staticClass, _getView11235)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGravity11236; 
		public virtual int getGravity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getGravity11236); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getGravity11236); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuration11237; 
		public virtual void setDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setDuration11237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setDuration11237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration11238; 
		public virtual int getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getDuration11238); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getDuration11238); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMargin11239; 
		public virtual void setMargin(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				@__env.CallVoidMethod(this, _setMargin11239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Toast.staticClass, _setMargin11239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalMargin11240; 
		public virtual float getHorizontalMargin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallFloatMethod(this, _getHorizontalMargin11240); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.Toast.staticClass, _getHorizontalMargin11240); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalMargin11241; 
		public virtual float getVerticalMargin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallFloatMethod(this, _getVerticalMargin11241); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.Toast.staticClass, _getVerticalMargin11241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXOffset11242; 
		public virtual int getXOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getXOffset11242); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getXOffset11242); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYOffset11243; 
		public virtual int getYOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Toast)) 
				return @__env.CallIntMethod(this, _getYOffset11243); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Toast.staticClass, _getYOffset11243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeText11244; 
		public static android.widget.Toast makeText(android.content.Context arg0, java.lang.CharSequence arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Toast>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.Toast.staticClass, _makeText11244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeText11245; 
		public static android.widget.Toast makeText(android.content.Context arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Toast>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.Toast.staticClass, _makeText11245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Toast11246; 
		public Toast(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Toast.staticClass, _Toast11246, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.widget.Toast._setText11229 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.Toast._setText11230 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setText", "(I)V"); 
			global::android.widget.Toast._cancel11231 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "cancel", "()V"); 
			global::android.widget.Toast._setGravity11232 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setGravity", "(III)V"); 
			global::android.widget.Toast._show11233 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "show", "()V"); 
			global::android.widget.Toast._setView11234 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setView", "(Landroid/view/View;)V"); 
			global::android.widget.Toast._getView11235 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getView", "()Landroid/view/View;"); 
			global::android.widget.Toast._getGravity11236 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getGravity", "()I"); 
			global::android.widget.Toast._setDuration11237 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setDuration", "(I)V"); 
			global::android.widget.Toast._getDuration11238 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getDuration", "()I"); 
			global::android.widget.Toast._setMargin11239 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "setMargin", "(FF)V"); 
			global::android.widget.Toast._getHorizontalMargin11240 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getHorizontalMargin", "()F"); 
			global::android.widget.Toast._getVerticalMargin11241 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getVerticalMargin", "()F"); 
			global::android.widget.Toast._getXOffset11242 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getXOffset", "()I"); 
			global::android.widget.Toast._getYOffset11243 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "getYOffset", "()I"); 
			global::android.widget.Toast._makeText11244 = @__env.GetStaticMethodID(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;"); 
			global::android.widget.Toast._makeText11245 = @__env.GetStaticMethodID(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;"); 
			global::android.widget.Toast._Toast11246 = @__env.GetMethodID(global::android.widget.Toast.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
