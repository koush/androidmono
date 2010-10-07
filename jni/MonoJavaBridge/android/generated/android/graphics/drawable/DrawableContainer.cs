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
			internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3773;
			public override int getChangingConfigurations() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3773);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3773);
			}
			internal static global::net.sf.jni4net.jni.MethodId _isStateful3774;
			public virtual bool isStateful() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3774);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3774);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getOpacity3775;
			public virtual int getOpacity() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3775);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3775);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getChildCount3776;
			public virtual int getChildCount() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3776);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3776);
			}
			internal static global::net.sf.jni4net.jni.MethodId _addChild3777;
			public virtual int addChild(android.graphics.drawable.Drawable arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getChildren3778;
			public virtual global::android.graphics.drawable.Drawable[] getChildren() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3778));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3778));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setVariablePadding3779;
			public virtual void setVariablePadding(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantPadding3780;
			public virtual global::android.graphics.Rect getConstantPadding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3780));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3780));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setConstantSize3781;
			public virtual void setConstantSize(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isConstantSize3782;
			public virtual bool isConstantSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3782);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3782);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantWidth3783;
			public virtual int getConstantWidth() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3783);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3783);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantHeight3784;
			public virtual int getConstantHeight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3784);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3784);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantMinimumWidth3785;
			public virtual int getConstantMinimumWidth() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3785);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3785);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getConstantMinimumHeight3786;
			public virtual int getConstantMinimumHeight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3786);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3786);
			}
			internal static global::net.sf.jni4net.jni.MethodId _growArray3787;
			public virtual void growArray(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _canConstantState3788;
			public virtual bool canConstantState() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3788);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3788);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__class;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3773 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3774 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3775 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3776 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3777 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3778 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3779 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3780 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3781 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3782 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3783 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3784 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3785 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3786 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3787 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3788 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3789;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._draw3789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._draw3789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3790;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3790);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3791;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setDither3791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setDither3791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3792;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setAlpha3792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setAlpha3792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3793;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setColorFilter3793, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setColorFilter3793, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3794;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._isStateful3794);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._isStateful3794);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrent3795;
		public override global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer._getCurrent3795));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getCurrent3795));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3796;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._setVisible3796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setVisible3796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3797;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getOpacity3797);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getOpacity3797);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3798;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._onStateChange3798, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onStateChange3798, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3799;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._onLevelChange3799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onLevelChange3799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3800;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._onBoundsChange3800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onBoundsChange3800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3801;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3801);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3801);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3802;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3802);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3802);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3803;
		public override int getMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getMinimumWidth3803);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumWidth3803);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3804;
		public override int getMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer._getMinimumHeight3804);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumHeight3804);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3805;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._getPadding3805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getPadding3805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3806;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer._mutate3806));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._mutate3806));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3807;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer._getConstantState3807));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getConstantState3807));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3808;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._invalidateDrawable3808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._invalidateDrawable3808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3809;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._scheduleDrawable3809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._scheduleDrawable3809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3810;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _selectDrawable3811;
		public virtual bool selectDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer._selectDrawable3811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._selectDrawable3811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setConstantState3812;
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer._setConstantState3812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setConstantState3812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DrawableContainer3813;
		public DrawableContainer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._DrawableContainer3813, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.DrawableContainer.staticClass = @__class;
			global::android.graphics.drawable.DrawableContainer._draw3789 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3790 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.DrawableContainer._setDither3791 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.DrawableContainer._setAlpha3792 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.DrawableContainer._setColorFilter3793 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.DrawableContainer._isStateful3794 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.DrawableContainer._getCurrent3795 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._setVisible3796 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.DrawableContainer._getOpacity3797 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.DrawableContainer._onStateChange3798 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.DrawableContainer._onLevelChange3799 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._onBoundsChange3800 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3801 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3802 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumWidth3803 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumHeight3804 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getPadding3805 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.DrawableContainer._mutate3806 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._getConstantState3807 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.DrawableContainer._invalidateDrawable3808 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.DrawableContainer._scheduleDrawable3809 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3810 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.DrawableContainer._selectDrawable3811 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._setConstantState3812 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V");
			global::android.graphics.drawable.DrawableContainer._DrawableContainer3813 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V");
		}
	}
}
