namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DrawableContainer : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::java.lang.Class staticClass;
		static DrawableContainer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.DrawableContainer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.DrawableContainer(@__env);
			}
		}
		protected DrawableContainer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public abstract class DrawableContainerState : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::java.lang.Class staticClass;
			static DrawableContainerState()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			protected DrawableContainerState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3567;
			public override int getChangingConfigurations() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3567);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3567);
			}
			internal static global::net.sf.jni4net.jni.MethodId _isStateful3568;
			public virtual bool isStateful() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3568);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3568);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getOpacity3569;
			public virtual int getOpacity() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3569);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3569);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getChildCount3570;
			public virtual int getChildCount() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3570);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3570);
			}
			internal static global::net.sf.jni4net.jni.MethodId _addChild3571;
			public virtual int addChild(android.graphics.drawable.Drawable arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getChildren3572;
			public virtual global::android.graphics.drawable.Drawable[] getChildren() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3572));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3572));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setVariablePadding3573;
			public virtual void setVariablePadding(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantPadding3574;
			public virtual global::android.graphics.Rect getConstantPadding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3574));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3574));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setConstantSize3575;
			public virtual void setConstantSize(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isConstantSize3576;
			public virtual bool isConstantSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3576);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3576);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantWidth3577;
			public virtual int getConstantWidth() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3577);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3577);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantHeight3578;
			public virtual int getConstantHeight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3578);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3578);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantMinimumWidth3579;
			public virtual int getConstantMinimumWidth() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3579);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3579);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantMinimumHeight3580;
			public virtual int getConstantMinimumHeight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3580);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3580);
			}
			internal static global::net.sf.jni4net.jni.MethodId _growArray3581;
			public virtual void growArray(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _canConstantState3582;
			public virtual bool canConstantState() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3582);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3582);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__class;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3567 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3568 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3569 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3570 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3571 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3572 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3573 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3574 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3575 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3576 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3577 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3578 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3579 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3580 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3581 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3582 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3583;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._draw3583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._draw3583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3584;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3584);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3584);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3585;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setDither3585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setDither3585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3586;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setAlpha3586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setAlpha3586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3587;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setColorFilter3587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setColorFilter3587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3588;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._isStateful3588);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._isStateful3588);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrent3589;
		public override global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer._getCurrent3589));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getCurrent3589));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3590;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._setVisible3590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setVisible3590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3591;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getOpacity3591);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getOpacity3591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3592;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._onStateChange3592, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onStateChange3592, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3593;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._onLevelChange3593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onLevelChange3593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3594;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._onBoundsChange3594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onBoundsChange3594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3595;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3595);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3595);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3596;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3596);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3596);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3597;
		public override int getMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getMinimumWidth3597);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumWidth3597);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3598;
		public override int getMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getMinimumHeight3598);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumHeight3598);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3599;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._getPadding3599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getPadding3599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3600;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer._mutate3600));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._mutate3600));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3601;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer._getConstantState3601));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getConstantState3601));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3602;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._invalidateDrawable3602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._invalidateDrawable3602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3603;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._scheduleDrawable3603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._scheduleDrawable3603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3604;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _selectDrawable3605;
		public virtual bool selectDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._selectDrawable3605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._selectDrawable3605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setConstantState3606;
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setConstantState3606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setConstantState3606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DrawableContainer3607;
		public DrawableContainer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._DrawableContainer3607, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.DrawableContainer.staticClass = @__class;
			global::android.graphics.drawable.DrawableContainer._draw3583 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3584 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.DrawableContainer._setDither3585 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.DrawableContainer._setAlpha3586 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.DrawableContainer._setColorFilter3587 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.DrawableContainer._isStateful3588 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.DrawableContainer._getCurrent3589 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._setVisible3590 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.DrawableContainer._getOpacity3591 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.DrawableContainer._onStateChange3592 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.DrawableContainer._onLevelChange3593 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._onBoundsChange3594 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3595 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3596 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumWidth3597 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumHeight3598 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getPadding3599 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.DrawableContainer._mutate3600 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._getConstantState3601 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.DrawableContainer._invalidateDrawable3602 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.DrawableContainer._scheduleDrawable3603 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3604 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.DrawableContainer._selectDrawable3605 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._setConstantState3606 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V");
			global::android.graphics.drawable.DrawableContainer._DrawableContainer3607 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V");
		}
	}
}
