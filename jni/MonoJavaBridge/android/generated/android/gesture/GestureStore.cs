namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GestureStore : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GestureStore()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureStore), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.gesture.GestureStore(@__env);
			}
		}
		protected GestureStore(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _load2859;
		public virtual void load(java.io.InputStream arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._load2859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._load2859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load2860;
		public virtual void load(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._load2860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._load2860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _save2861;
		public virtual void save(java.io.OutputStream arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._save2861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._save2861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _save2862;
		public virtual void save(java.io.OutputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._save2862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._save2862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasChanged2863;
		public virtual bool hasChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureStore._hasChanged2863);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._hasChanged2863);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrientationStyle2864;
		public virtual void setOrientationStyle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._setOrientationStyle2864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._setOrientationStyle2864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrientationStyle2865;
		public virtual int getOrientationStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.GestureStore._getOrientationStyle2865);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getOrientationStyle2865);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSequenceType2866;
		public virtual void setSequenceType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._setSequenceType2866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._setSequenceType2866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSequenceType2867;
		public virtual int getSequenceType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.GestureStore._getSequenceType2867);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getSequenceType2867);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureEntries2868;
		public virtual global::java.util.Set getGestureEntries() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStore._getGestureEntries2868));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getGestureEntries2868));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recognize2869;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStore._recognize2869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._recognize2869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addGesture2870;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._addGesture2870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._addGesture2870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGesture2871;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._removeGesture2871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._removeGesture2871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeEntry2872;
		public virtual void removeEntry(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStore._removeEntry2872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._removeEntry2872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestures2873;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStore._getGestures2873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getGestures2873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureStore2874;
		public GestureStore()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._GestureStore2874, this);
		}
		public static int SEQUENCE_INVARIANT
		{
			get
			{
				return 1;
			}
		}
		public static int SEQUENCE_SENSITIVE
		{
			get
			{
				return 2;
			}
		}
		public static int ORIENTATION_INVARIANT
		{
			get
			{
				return 1;
			}
		}
		public static int ORIENTATION_SENSITIVE
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.gesture.GestureStore.staticClass = @__class;
			global::android.gesture.GestureStore._load2859 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;Z)V");
			global::android.gesture.GestureStore._load2860 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::android.gesture.GestureStore._save2861 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;Z)V");
			global::android.gesture.GestureStore._save2862 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;)V");
			global::android.gesture.GestureStore._hasChanged2863 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "hasChanged", "()Z");
			global::android.gesture.GestureStore._setOrientationStyle2864 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "setOrientationStyle", "(I)V");
			global::android.gesture.GestureStore._getOrientationStyle2865 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getOrientationStyle", "()I");
			global::android.gesture.GestureStore._setSequenceType2866 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "setSequenceType", "(I)V");
			global::android.gesture.GestureStore._getSequenceType2867 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getSequenceType", "()I");
			global::android.gesture.GestureStore._getGestureEntries2868 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getGestureEntries", "()Ljava/util/Set;");
			global::android.gesture.GestureStore._recognize2869 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;");
			global::android.gesture.GestureStore._addGesture2870 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureStore._removeGesture2871 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureStore._removeEntry2872 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "removeEntry", "(Ljava/lang/String;)V");
			global::android.gesture.GestureStore._getGestures2873 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.gesture.GestureStore._GestureStore2874 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "<init>", "()V");
		}
	}
}
