namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RectF : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static RectF()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.RectF), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.RectF(@__env);
			}
		}
		protected RectF(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString3522;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.RectF._toString3522));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._toString3522));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offset3523;
		public virtual void offset(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._offset3523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offset3523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3524;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._isEmpty3524);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._isEmpty3524);
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3525;
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._contains3525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3526;
		public virtual bool contains(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._contains3526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3527;
		public virtual bool contains(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._contains3527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3528;
		public virtual void set(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._set3528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3529;
		public virtual void set(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._set3529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3530;
		public virtual void set(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._set3530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sort3531;
		public virtual void sort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._sort3531);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._sort3531);
		}
		internal static global::net.sf.jni4net.jni.MethodId _round3532;
		public virtual void round(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._round3532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._round3532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersects3533;
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects3533, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersects3534;
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._intersects3534, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects3534, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3535;
		public virtual void union(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._union3535, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3535, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3536;
		public virtual void union(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._union3536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3537;
		public virtual void union(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._union3537, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3537, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _centerX3538;
		public virtual float centerX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._centerX3538);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerX3538);
		}
		internal static global::net.sf.jni4net.jni.MethodId _centerY3539;
		public virtual float centerY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._centerY3539);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerY3539);
		}
		internal static global::net.sf.jni4net.jni.MethodId _height3540;
		public virtual float height() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._height3540);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._height3540);
		}
		internal static global::net.sf.jni4net.jni.MethodId _width3541;
		public virtual float width() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._width3541);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._width3541);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3542;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._writeToParcel3542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._writeToParcel3542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3543;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.RectF._describeContents3543);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._describeContents3543);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel3544;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._readFromParcel3544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._readFromParcel3544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3545;
		public virtual void setEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._setEmpty3545);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setEmpty3545);
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetTo3546;
		public virtual void offsetTo(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._offsetTo3546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offsetTo3546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inset3547;
		public virtual void inset(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._inset3547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._inset3547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersect3548;
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._intersect3548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect3548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersect3549;
		public virtual bool intersect(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._intersect3549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect3549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntersect3550;
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._setIntersect3550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setIntersect3550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _roundOut3551;
		public virtual void roundOut(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.RectF._roundOut3551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._roundOut3551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RectF3552;
		public RectF()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3552, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _RectF3553;
		public RectF(float arg0, float arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3553, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RectF3554;
		public RectF(android.graphics.RectF arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3554, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RectF3555;
		public RectF(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3555, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _left3556;
		public float left
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _top3557;
		public float top
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _right3558;
		public float right
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _bottom3559;
		public float bottom
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3560;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.RectF.staticClass = @__class;
			global::android.graphics.RectF._toString3522 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.RectF._offset3523 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "offset", "(FF)V");
			global::android.graphics.RectF._isEmpty3524 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "isEmpty", "()Z");
			global::android.graphics.RectF._contains3525 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z");
			global::android.graphics.RectF._contains3526 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(FF)Z");
			global::android.graphics.RectF._contains3527 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._set3528 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._set3529 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(FFFF)V");
			global::android.graphics.RectF._set3530 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._sort3531 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "sort", "()V");
			global::android.graphics.RectF._round3532 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._intersects3533 = @__env.GetStaticMethodID(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._intersects3534 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z");
			global::android.graphics.RectF._union3535 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._union3536 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(FFFF)V");
			global::android.graphics.RectF._union3537 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(FF)V");
			global::android.graphics.RectF._centerX3538 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "centerX", "()F");
			global::android.graphics.RectF._centerY3539 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "centerY", "()F");
			global::android.graphics.RectF._height3540 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "height", "()F");
			global::android.graphics.RectF._width3541 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "width", "()F");
			global::android.graphics.RectF._writeToParcel3542 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.RectF._describeContents3543 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "describeContents", "()I");
			global::android.graphics.RectF._readFromParcel3544 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.RectF._setEmpty3545 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "setEmpty", "()V");
			global::android.graphics.RectF._offsetTo3546 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V");
			global::android.graphics.RectF._inset3547 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "inset", "(FF)V");
			global::android.graphics.RectF._intersect3548 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z");
			global::android.graphics.RectF._intersect3549 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._setIntersect3550 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._roundOut3551 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._RectF3552 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "()V");
			global::android.graphics.RectF._RectF3553 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V");
			global::android.graphics.RectF._RectF3554 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._RectF3555 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
		}
	}
}
