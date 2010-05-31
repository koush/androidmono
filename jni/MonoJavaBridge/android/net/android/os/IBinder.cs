namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface IBinder 
	{ 
		void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1); 
		global::java.lang.String getInterfaceDescriptor(); 
		bool pingBinder(); 
		bool isBinderAlive(); 
		global::android.os.IInterface queryLocalInterface(java.lang.String arg0); 
		bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3); 
		void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1); 
		bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1); 
	} 

	public partial class IBinder_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __IBinder.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __IBinder : java.lang.Object, IBinder
	{ 
		internal static global::java.lang.Class staticClass; 
		static __IBinder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.__IBinder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.__IBinder(@__env); 
			} 
		} 
		internal __IBinder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5619; 
		 void android.os.IBinder.dump(java.io.FileDescriptor arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.__IBinder._dump5619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._dump5619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterfaceDescriptor5620; 
		 global::java.lang.String android.os.IBinder.getInterfaceDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.__IBinder._getInterfaceDescriptor5620)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._getInterfaceDescriptor5620)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pingBinder5621; 
		 bool android.os.IBinder.pingBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.__IBinder._pingBinder5621); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._pingBinder5621); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBinderAlive5622; 
		 bool android.os.IBinder.isBinderAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.__IBinder._isBinderAlive5622); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._isBinderAlive5622); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queryLocalInterface5623; 
		 global::android.os.IInterface android.os.IBinder.queryLocalInterface(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.__IBinder._queryLocalInterface5623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._queryLocalInterface5623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transact5624; 
		 bool android.os.IBinder.transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.__IBinder._transact5624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._transact5624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _linkToDeath5625; 
		 void android.os.IBinder.linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.__IBinder._linkToDeath5625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._linkToDeath5625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlinkToDeath5626; 
		 bool android.os.IBinder.unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.__IBinder._unlinkToDeath5626, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.__IBinder.staticClass, global::android.os.__IBinder._unlinkToDeath5626, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.__IBinder.staticClass = @__class; 
			global::android.os.__IBinder._dump5619 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V"); 
			global::android.os.__IBinder._getInterfaceDescriptor5620 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.getInterfaceDescriptor", "()Ljava/lang/String;"); 
			global::android.os.__IBinder._pingBinder5621 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.pingBinder", "()Z"); 
			global::android.os.__IBinder._isBinderAlive5622 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.isBinderAlive", "()Z"); 
			global::android.os.__IBinder._queryLocalInterface5623 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;"); 
			global::android.os.__IBinder._transact5624 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"); 
			global::android.os.__IBinder._linkToDeath5625 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V"); 
			global::android.os.__IBinder._unlinkToDeath5626 = @__env.GetMethodID(global::android.os.__IBinder.staticClass, "android.os.IBinder.unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z"); 
		} 
	} 
} 
