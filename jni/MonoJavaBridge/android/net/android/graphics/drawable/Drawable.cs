namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Drawable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Drawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.Drawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Drawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Callback 
		{ 
			void invalidateDrawable(android.graphics.drawable.Drawable arg0); 
			void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2); 
			void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1); 
		} 

		public partial class Callback_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __Callback.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __Callback : java.lang.Object, Callback
		{ 
			internal static global::java.lang.Class staticClass; 
			static __Callback() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.Drawable.__Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.drawable.Drawable.__Callback(@__env); 
				} 
			} 
			internal __Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3513; 
			 void android.graphics.drawable.Drawable.Callback.invalidateDrawable(android.graphics.drawable.Drawable arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback._invalidateDrawable3513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback.staticClass, global::android.graphics.drawable.Drawable.__Callback._invalidateDrawable3513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3514; 
			 void android.graphics.drawable.Drawable.Callback.scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback._scheduleDrawable3514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback.staticClass, global::android.graphics.drawable.Drawable.__Callback._scheduleDrawable3514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3515; 
			 void android.graphics.drawable.Drawable.Callback.unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback._unscheduleDrawable3515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback.staticClass, global::android.graphics.drawable.Drawable.__Callback._unscheduleDrawable3515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.Drawable.__Callback.staticClass = @__class; 
				global::android.graphics.drawable.Drawable.__Callback._invalidateDrawable3513 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.__Callback.staticClass, "android.graphics.drawable.Drawable.Callback.invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
				global::android.graphics.drawable.Drawable.__Callback._scheduleDrawable3514 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.__Callback.staticClass, "android.graphics.drawable.Drawable.Callback.scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
				global::android.graphics.drawable.Drawable.__Callback._unscheduleDrawable3515 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.__Callback.staticClass, "android.graphics.drawable.Drawable.Callback.unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class ConstantState : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ConstantState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.Drawable.ConstantState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected ConstantState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3516; 
			public abstract int getChangingConfigurations(); 
			internal static global::net.sf.jni4net.jni.MethodId _newDrawable3517; 
			public abstract global::android.graphics.drawable.Drawable newDrawable(); 
			internal static global::net.sf.jni4net.jni.MethodId _newDrawable3518; 
			public virtual global::android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable.ConstantState._newDrawable3518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._newDrawable3518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ConstantState3519; 
			public ConstantState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._ConstantState3519, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__class; 
				global::android.graphics.drawable.Drawable.ConstantState._getChangingConfigurations3516 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "getChangingConfigurations", "()I"); 
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3517 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;"); 
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3518 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;"); 
				global::android.graphics.drawable.Drawable.ConstantState._ConstantState3519 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState3520; 
		public virtual int[] getState() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getState3520)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getState3520)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setState3521; 
		public virtual bool setState(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._setState3521, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setState3521, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3522; 
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._inflate3522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._inflate3522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3523; 
		public abstract void draw(android.graphics.Canvas arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setBounds3524; 
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setBounds3524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds3524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBounds3525; 
		public virtual void setBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setBounds3525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds3525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyBounds3526; 
		public virtual void copyBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._copyBounds3526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds3526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyBounds3527; 
		public virtual global::android.graphics.Rect copyBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._copyBounds3527)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds3527)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3528; 
		public virtual global::android.graphics.Rect getBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getBounds3528)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getBounds3528)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChangingConfigurations3529; 
		public virtual void setChangingConfigurations(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setChangingConfigurations3529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setChangingConfigurations3529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3530; 
		public virtual int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getChangingConfigurations3530); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getChangingConfigurations3530); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3531; 
		public virtual void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setDither3531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setDither3531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3532; 
		public virtual void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setFilterBitmap3532, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setFilterBitmap3532, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCallback3533; 
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setCallback3533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setCallback3533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateSelf3534; 
		public virtual void invalidateSelf() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._invalidateSelf3534); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._invalidateSelf3534); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleSelf3535; 
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._scheduleSelf3535, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._scheduleSelf3535, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleSelf3536; 
		public virtual void unscheduleSelf(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._unscheduleSelf3536, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._unscheduleSelf3536, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3537; 
		public abstract void setAlpha(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3538; 
		public abstract void setColorFilter(android.graphics.ColorFilter arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3539; 
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setColorFilter3539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setColorFilter3539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearColorFilter3540; 
		public virtual void clearColorFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._clearColorFilter3540); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._clearColorFilter3540); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3541; 
		public virtual bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._isStateful3541); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isStateful3541); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrent3542; 
		public virtual global::android.graphics.drawable.Drawable getCurrent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getCurrent3542)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getCurrent3542)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLevel3543; 
		public virtual bool setLevel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._setLevel3543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setLevel3543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLevel3544; 
		public virtual int getLevel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getLevel3544); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getLevel3544); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3545; 
		public virtual bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._setVisible3545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setVisible3545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVisible3546; 
		public virtual bool isVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._isVisible3546); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isVisible3546); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3547; 
		public abstract int getOpacity(); 
		internal static global::net.sf.jni4net.jni.MethodId _resolveOpacity3548; 
		public static int resolveOpacity(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._resolveOpacity3548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3549; 
		public virtual global::android.graphics.Region getTransparentRegion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getTransparentRegion3549)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getTransparentRegion3549)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3550; 
		protected virtual bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._onStateChange3550, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onStateChange3550, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3551; 
		protected virtual bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._onLevelChange3551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onLevelChange3551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3552; 
		protected virtual void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._onBoundsChange3552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onBoundsChange3552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3553; 
		public virtual int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getIntrinsicWidth3553); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicWidth3553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3554; 
		public virtual int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getIntrinsicHeight3554); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicHeight3554); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3555; 
		public virtual int getMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getMinimumWidth3555); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumWidth3555); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3556; 
		public virtual int getMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getMinimumHeight3556); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumHeight3556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3557; 
		public virtual bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._getPadding3557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getPadding3557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3558; 
		public virtual global::android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._mutate3558)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._mutate3558)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromStream3559; 
		public static global::android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromStream3559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromResourceStream3560; 
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream3560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromResourceStream3561; 
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream3561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromXml3562; 
		public static global::android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXml3562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromXmlInner3563; 
		public static global::android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXmlInner3563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromPath3564; 
		public static global::android.graphics.drawable.Drawable createFromPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromPath3564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3565; 
		public virtual global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getConstantState3565)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getConstantState3565)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Drawable3566; 
		public Drawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._Drawable3566, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.Drawable.staticClass = @__class; 
			global::android.graphics.drawable.Drawable._getState3520 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I"); 
			global::android.graphics.drawable.Drawable._setState3521 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z"); 
			global::android.graphics.drawable.Drawable._inflate3522 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.Drawable._draw3523 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.Drawable._setBounds3524 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V"); 
			global::android.graphics.drawable.Drawable._setBounds3525 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.Drawable._copyBounds3526 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.Drawable._copyBounds3527 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;"); 
			global::android.graphics.drawable.Drawable._getBounds3528 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;"); 
			global::android.graphics.drawable.Drawable._setChangingConfigurations3529 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V"); 
			global::android.graphics.drawable.Drawable._getChangingConfigurations3530 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.Drawable._setDither3531 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.Drawable._setFilterBitmap3532 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.drawable.Drawable._setCallback3533 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V"); 
			global::android.graphics.drawable.Drawable._invalidateSelf3534 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V"); 
			global::android.graphics.drawable.Drawable._scheduleSelf3535 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.Drawable._unscheduleSelf3536 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.Drawable._setAlpha3537 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.Drawable._setColorFilter3538 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.Drawable._setColorFilter3539 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V"); 
			global::android.graphics.drawable.Drawable._clearColorFilter3540 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V"); 
			global::android.graphics.drawable.Drawable._isStateful3541 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.Drawable._getCurrent3542 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._setLevel3543 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z"); 
			global::android.graphics.drawable.Drawable._getLevel3544 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I"); 
			global::android.graphics.drawable.Drawable._setVisible3545 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.Drawable._isVisible3546 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z"); 
			global::android.graphics.drawable.Drawable._getOpacity3547 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.Drawable._resolveOpacity3548 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I"); 
			global::android.graphics.drawable.Drawable._getTransparentRegion3549 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;"); 
			global::android.graphics.drawable.Drawable._onStateChange3550 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.Drawable._onLevelChange3551 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.Drawable._onBoundsChange3552 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.Drawable._getIntrinsicWidth3553 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.Drawable._getIntrinsicHeight3554 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.Drawable._getMinimumWidth3555 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I"); 
			global::android.graphics.drawable.Drawable._getMinimumHeight3556 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I"); 
			global::android.graphics.drawable.Drawable._getPadding3557 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.Drawable._mutate3558 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromStream3559 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromResourceStream3560 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromResourceStream3561 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromXml3562 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromXmlInner3563 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromPath3564 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._getConstantState3565 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.Drawable._Drawable3566 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
