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
		internal static global::net.sf.jni4net.jni.MethodId _toString3323; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.RectF._toString3323)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._toString3323)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3324; 
		public virtual void offset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._offset3324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offset3324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3325; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._isEmpty3325); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._isEmpty3325); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3326; 
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._contains3326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3327; 
		public virtual bool contains(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._contains3327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3328; 
		public virtual bool contains(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._contains3328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3329; 
		public virtual void set(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._set3329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3330; 
		public virtual void set(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._set3330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3331; 
		public virtual void set(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._set3331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sort3332; 
		public virtual void sort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._sort3332); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._sort3332); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _round3333; 
		public virtual void round(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._round3333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._round3333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3334; 
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects3334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3335; 
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._intersects3335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects3335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3336; 
		public virtual void union(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._union3336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3337; 
		public virtual void union(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._union3337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3338; 
		public virtual void union(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._union3338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerX3339; 
		public virtual float centerX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._centerX3339); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerX3339); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerY3340; 
		public virtual float centerY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._centerY3340); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerY3340); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _height3341; 
		public virtual float height() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._height3341); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._height3341); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _width3342; 
		public virtual float width() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.graphics.RectF._width3342); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._width3342); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3343; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._writeToParcel3343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._writeToParcel3343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3344; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.RectF._describeContents3344); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._describeContents3344); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel3345; 
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._readFromParcel3345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._readFromParcel3345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3346; 
		public virtual void setEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._setEmpty3346); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setEmpty3346); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetTo3347; 
		public virtual void offsetTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._offsetTo3347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offsetTo3347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inset3348; 
		public virtual void inset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._inset3348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._inset3348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3349; 
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._intersect3349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect3349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3350; 
		public virtual bool intersect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._intersect3350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect3350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntersect3351; 
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.RectF._setIntersect3351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setIntersect3351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _roundOut3352; 
		public virtual void roundOut(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.RectF._roundOut3352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._roundOut3352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3353; 
		public RectF()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3353, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3354; 
		public RectF(float arg0, float arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3354, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3355; 
		public RectF(android.graphics.RectF arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3355, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3356; 
		public RectF(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3356, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _left3357; 
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
		internal static global::net.sf.jni4net.jni.FieldId _top3358; 
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
		internal static global::net.sf.jni4net.jni.FieldId _right3359; 
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
		internal static global::net.sf.jni4net.jni.FieldId _bottom3360; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3361; 
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
			global::android.graphics.RectF._toString3323 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.RectF._offset3324 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "offset", "(FF)V"); 
			global::android.graphics.RectF._isEmpty3325 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.RectF._contains3326 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z"); 
			global::android.graphics.RectF._contains3327 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(FF)Z"); 
			global::android.graphics.RectF._contains3328 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._set3329 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V"); 
			global::android.graphics.RectF._set3330 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(FFFF)V"); 
			global::android.graphics.RectF._set3331 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.RectF._sort3332 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "sort", "()V"); 
			global::android.graphics.RectF._round3333 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.RectF._intersects3334 = @__env.GetStaticMethodID(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._intersects3335 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z"); 
			global::android.graphics.RectF._union3336 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V"); 
			global::android.graphics.RectF._union3337 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(FFFF)V"); 
			global::android.graphics.RectF._union3338 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(FF)V"); 
			global::android.graphics.RectF._centerX3339 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "centerX", "()F"); 
			global::android.graphics.RectF._centerY3340 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "centerY", "()F"); 
			global::android.graphics.RectF._height3341 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "height", "()F"); 
			global::android.graphics.RectF._width3342 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "width", "()F"); 
			global::android.graphics.RectF._writeToParcel3343 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.RectF._describeContents3344 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "describeContents", "()I"); 
			global::android.graphics.RectF._readFromParcel3345 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.graphics.RectF._setEmpty3346 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "setEmpty", "()V"); 
			global::android.graphics.RectF._offsetTo3347 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V"); 
			global::android.graphics.RectF._inset3348 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "inset", "(FF)V"); 
			global::android.graphics.RectF._intersect3349 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z"); 
			global::android.graphics.RectF._intersect3350 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._setIntersect3351 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._roundOut3352 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.RectF._RectF3353 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "()V"); 
			global::android.graphics.RectF._RectF3354 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V"); 
			global::android.graphics.RectF._RectF3355 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V"); 
			global::android.graphics.RectF._RectF3356 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V"); 
		} 
	} 
} 
