namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Region : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Region() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Region), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Region(@__env); 
			} 
		} 
		protected Region(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Op : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Op() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Region.Op), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Region.Op(@__env); 
				} 
			} 
			internal Op(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3162; 
			public static android.graphics.Region.Op valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region.Op>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Region.Op.staticClass, _valueOf3162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3163; 
			public static android.graphics.Region.Op[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Region.Op.staticClass, _values3163)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DIFFERENCE3164; 
			public static android.graphics.Region.Op DIFFERENCE
			{ 
				get 
				{ 
					return default(android.graphics.Region.Op); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INTERSECT3165; 
			public static android.graphics.Region.Op INTERSECT
			{ 
				get 
				{ 
					return default(android.graphics.Region.Op); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _REPLACE3166; 
			public static android.graphics.Region.Op REPLACE
			{ 
				get 
				{ 
					return default(android.graphics.Region.Op); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _REVERSE_DIFFERENCE3167; 
			public static android.graphics.Region.Op REVERSE_DIFFERENCE
			{ 
				get 
				{ 
					return default(android.graphics.Region.Op); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _UNION3168; 
			public static android.graphics.Region.Op UNION
			{ 
				get 
				{ 
					return default(android.graphics.Region.Op); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _XOR3169; 
			public static android.graphics.Region.Op XOR
			{ 
				get 
				{ 
					return default(android.graphics.Region.Op); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Region.Op.staticClass = @__class; 
				global::android.graphics.Region.Op._valueOf3162 = @__env.GetStaticMethodID(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;"); 
				global::android.graphics.Region.Op._values3163 = @__env.GetStaticMethodID(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals3170; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _equals3170, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _equals3170, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3171; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _isEmpty3171); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _isEmpty3171); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3172; 
		public virtual bool contains(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _contains3172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _contains3172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3173; 
		public virtual bool set(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _set3173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _set3173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3174; 
		public virtual bool set(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _set3174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _set3174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3175; 
		public virtual bool set(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _set3175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _set3175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3176; 
		public virtual bool union(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _union3176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _union3176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3177; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				@__env.CallVoidMethod(this, _writeToParcel3177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Region.staticClass, _writeToParcel3177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3178; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallIntMethod(this, _describeContents3178); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Region.staticClass, _describeContents3178); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3179; 
		public virtual android.graphics.Rect getBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, _getBounds3179)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Region.staticClass, _getBounds3179)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3180; 
		public virtual bool getBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _getBounds3180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _getBounds3180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _translate3181; 
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				@__env.CallVoidMethod(this, _translate3181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Region.staticClass, _translate3181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _translate3182; 
		public virtual void translate(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				@__env.CallVoidMethod(this, _translate3182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Region.staticClass, _translate3182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _op3183; 
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _op3183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _op3183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _op3184; 
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _op3184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _op3184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _op3185; 
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _op3185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _op3185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _op3186; 
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _op3186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _op3186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _op3187; 
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _op3187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _op3187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3188; 
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _quickReject3188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _quickReject3188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3189; 
		public virtual bool quickReject(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _quickReject3189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _quickReject3189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3190; 
		public virtual bool quickReject(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _quickReject3190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _quickReject3190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3191; 
		public virtual void setEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				@__env.CallVoidMethod(this, _setEmpty3191); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Region.staticClass, _setEmpty3191); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPath3192; 
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _setPath3192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _setPath3192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRect3193; 
		public virtual bool isRect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _isRect3193); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _isRect3193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isComplex3194; 
		public virtual bool isComplex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _isComplex3194); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _isComplex3194); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoundaryPath3195; 
		public virtual android.graphics.Path getBoundaryPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _getBoundaryPath3195)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Region.staticClass, _getBoundaryPath3195)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoundaryPath3196; 
		public virtual bool getBoundaryPath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _getBoundaryPath3196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _getBoundaryPath3196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickContains3197; 
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _quickContains3197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _quickContains3197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickContains3198; 
		public virtual bool quickContains(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Region)) 
				return @__env.CallBooleanMethod(this, _quickContains3198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Region.staticClass, _quickContains3198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Region3199; 
		public Region()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Region.staticClass, _Region3199, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Region3200; 
		public Region(android.graphics.Region arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Region.staticClass, _Region3200, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Region3201; 
		public Region(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Region.staticClass, _Region3201, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Region3202; 
		public Region(int arg0, int arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Region.staticClass, _Region3202, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3203; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Region.staticClass = @__class; 
			global::android.graphics.Region._equals3170 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.graphics.Region._isEmpty3171 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.Region._contains3172 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "contains", "(II)Z"); 
			global::android.graphics.Region._set3173 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z"); 
			global::android.graphics.Region._set3174 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(IIII)Z"); 
			global::android.graphics.Region._set3175 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Region._union3176 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Region._writeToParcel3177 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.Region._describeContents3178 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "describeContents", "()I"); 
			global::android.graphics.Region._getBounds3179 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;"); 
			global::android.graphics.Region._getBounds3180 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Region._translate3181 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V"); 
			global::android.graphics.Region._translate3182 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "translate", "(II)V"); 
			global::android.graphics.Region._op3183 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Region._op3184 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Region._op3185 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Region._op3186 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Region._op3187 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Region._quickReject3188 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z"); 
			global::android.graphics.Region._quickReject3189 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Region._quickReject3190 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z"); 
			global::android.graphics.Region._setEmpty3191 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "setEmpty", "()V"); 
			global::android.graphics.Region._setPath3192 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z"); 
			global::android.graphics.Region._isRect3193 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isRect", "()Z"); 
			global::android.graphics.Region._isComplex3194 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isComplex", "()Z"); 
			global::android.graphics.Region._getBoundaryPath3195 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;"); 
			global::android.graphics.Region._getBoundaryPath3196 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z"); 
			global::android.graphics.Region._quickContains3197 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z"); 
			global::android.graphics.Region._quickContains3198 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Region._Region3199 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "()V"); 
			global::android.graphics.Region._Region3200 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V"); 
			global::android.graphics.Region._Region3201 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.Region._Region3202 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(IIII)V"); 
		} 
	} 
} 
