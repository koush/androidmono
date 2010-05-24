namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GradientDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GradientDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.GradientDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.GradientDrawable(@__env); 
			} 
		} 
		protected GradientDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Orientation : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Orientation() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.GradientDrawable.Orientation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.drawable.GradientDrawable.Orientation(@__env); 
				} 
			} 
			internal Orientation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3608; 
			public static android.graphics.drawable.GradientDrawable.Orientation valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.GradientDrawable.Orientation>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.GradientDrawable.Orientation.staticClass, _valueOf3608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3609; 
			public static android.graphics.drawable.GradientDrawable.Orientation[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.GradientDrawable.Orientation.staticClass, _values3609)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BL_TR3610; 
			public static android.graphics.drawable.GradientDrawable.Orientation BL_TR
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BOTTOM_TOP3611; 
			public static android.graphics.drawable.GradientDrawable.Orientation BOTTOM_TOP
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BR_TL3612; 
			public static android.graphics.drawable.GradientDrawable.Orientation BR_TL
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LEFT_RIGHT3613; 
			public static android.graphics.drawable.GradientDrawable.Orientation LEFT_RIGHT
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT_LEFT3614; 
			public static android.graphics.drawable.GradientDrawable.Orientation RIGHT_LEFT
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TL_BR3615; 
			public static android.graphics.drawable.GradientDrawable.Orientation TL_BR
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TOP_BOTTOM3616; 
			public static android.graphics.drawable.GradientDrawable.Orientation TOP_BOTTOM
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TR_BL3617; 
			public static android.graphics.drawable.GradientDrawable.Orientation TR_BL
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.GradientDrawable.Orientation.staticClass = @__class; 
				global::android.graphics.drawable.GradientDrawable.Orientation._valueOf3608 = @__env.GetStaticMethodID(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;"); 
				global::android.graphics.drawable.GradientDrawable.Orientation._values3609 = @__env.GetStaticMethodID(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "values", "()[Landroid/graphics/drawable/GradientDrawable/Orientation;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSize3618; 
		public virtual void setSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setSize3618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setSize3618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3619; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _inflate3619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _inflate3619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3620; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _draw3620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _draw3620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3621; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3621); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getChangingConfigurations3621); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3622; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setDither3622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setDither3622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3623; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setAlpha3623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3624; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setColorFilter3624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3625; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3625); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getOpacity3625); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3626; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _onLevelChange3626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3627; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _onBoundsChange3627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3628; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3628); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getIntrinsicWidth3628); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3629; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3629); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getIntrinsicHeight3629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3630; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getPadding3630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3631; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3631)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.GradientDrawable.staticClass, _mutate3631)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3632; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3632)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.GradientDrawable.staticClass, _getConstantState3632)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColor3633; 
		public virtual void setColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setColor3633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setColor3633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadii3634; 
		public virtual void setCornerRadii(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setCornerRadii3634, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setCornerRadii3634, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadius3635; 
		public virtual void setCornerRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setCornerRadius3635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setCornerRadius3635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStroke3636; 
		public virtual void setStroke(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setStroke3636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setStroke3636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStroke3637; 
		public virtual void setStroke(int arg0, int arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setStroke3637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setStroke3637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShape3638; 
		public virtual void setShape(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setShape3638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setShape3638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGradientType3639; 
		public virtual void setGradientType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setGradientType3639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setGradientType3639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGradientCenter3640; 
		public virtual void setGradientCenter(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setGradientCenter3640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setGradientCenter3640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGradientRadius3641; 
		public virtual void setGradientRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setGradientRadius3641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setGradientRadius3641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUseLevel3642; 
		public virtual void setUseLevel(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setUseLevel3642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setUseLevel3642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GradientDrawable3643; 
		public GradientDrawable(android.graphics.drawable.GradientDrawable.Orientation arg0, int[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, _GradientDrawable3643, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GradientDrawable3644; 
		public GradientDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, _GradientDrawable3644, this); 
		} 
		public static int RECTANGLE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int OVAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int LINE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int RING
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int LINEAR_GRADIENT
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int RADIAL_GRADIENT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SWEEP_GRADIENT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.GradientDrawable.staticClass = @__class; 
			global::android.graphics.drawable.GradientDrawable._setSize3618 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setSize", "(II)V"); 
			global::android.graphics.drawable.GradientDrawable._inflate3619 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.GradientDrawable._draw3620 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.GradientDrawable._getChangingConfigurations3621 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.GradientDrawable._setDither3622 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.GradientDrawable._setAlpha3623 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setColorFilter3624 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.GradientDrawable._getOpacity3625 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.GradientDrawable._onLevelChange3626 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.GradientDrawable._onBoundsChange3627 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth3628 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight3629 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.GradientDrawable._getPadding3630 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.GradientDrawable._mutate3631 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.GradientDrawable._getConstantState3632 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.GradientDrawable._setColor3633 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setColor", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setCornerRadii3634 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadii", "([F)V"); 
			global::android.graphics.drawable.GradientDrawable._setCornerRadius3635 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadius", "(F)V"); 
			global::android.graphics.drawable.GradientDrawable._setStroke3636 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(II)V"); 
			global::android.graphics.drawable.GradientDrawable._setStroke3637 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(IIFF)V"); 
			global::android.graphics.drawable.GradientDrawable._setShape3638 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setShape", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setGradientType3639 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientType", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setGradientCenter3640 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientCenter", "(FF)V"); 
			global::android.graphics.drawable.GradientDrawable._setGradientRadius3641 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientRadius", "(F)V"); 
			global::android.graphics.drawable.GradientDrawable._setUseLevel3642 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setUseLevel", "(Z)V"); 
			global::android.graphics.drawable.GradientDrawable._GradientDrawable3643 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V"); 
			global::android.graphics.drawable.GradientDrawable._GradientDrawable3644 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
