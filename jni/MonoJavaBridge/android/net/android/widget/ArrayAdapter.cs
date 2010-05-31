namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ArrayAdapter : android.widget.BaseAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ArrayAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ArrayAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ArrayAdapter(@__env); 
			} 
		} 
		protected ArrayAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add9864; 
		public virtual void add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._add9864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._add9864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear9865; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._clear9865); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._clear9865); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove9866; 
		public virtual void remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._remove9866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._remove9866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext9867; 
		public virtual global::android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getContext9867)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getContext9867)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert9868; 
		public virtual void insert(java.lang.Object arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._insert9868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._insert9868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sort9869; 
		public virtual void sort(java.util.Comparator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._sort9869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._sort9869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition9870; 
		public virtual int getPosition(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.ArrayAdapter._getPosition9870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getPosition9870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9871; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.ArrayAdapter._getCount9871); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getCount9871); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9872; 
		public override global::java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getItem9872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItem9872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9873; 
		public override long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.widget.ArrayAdapter._getItemId9873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItemId9873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9874; 
		public virtual global::android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getFilter9874)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getFilter9874)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView9875; 
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getView9875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getView9875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView9876; 
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getDropDownView9876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getDropDownView9876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9877; 
		public override void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._notifyDataSetChanged9877); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._notifyDataSetChanged9877); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotifyOnChange9878; 
		public virtual void setNotifyOnChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._setNotifyOnChange9878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setNotifyOnChange9878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource9879; 
		public virtual void setDropDownViewResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._setDropDownViewResource9879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setDropDownViewResource9879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromResource9880; 
		public static global::android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ArrayAdapter>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._createFromResource9880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9881; 
		public ArrayAdapter(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter9881, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9882; 
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter9882, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9883; 
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter9883, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9884; 
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter9884, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9885; 
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter9885, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9886; 
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter9886, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ArrayAdapter.staticClass = @__class; 
			global::android.widget.ArrayAdapter._add9864 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._clear9865 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "clear", "()V"); 
			global::android.widget.ArrayAdapter._remove9866 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._getContext9867 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.widget.ArrayAdapter._insert9868 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V"); 
			global::android.widget.ArrayAdapter._sort9869 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V"); 
			global::android.widget.ArrayAdapter._getPosition9870 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I"); 
			global::android.widget.ArrayAdapter._getCount9871 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.ArrayAdapter._getItem9872 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.ArrayAdapter._getItemId9873 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.ArrayAdapter._getFilter9874 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.ArrayAdapter._getView9875 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ArrayAdapter._getDropDownView9876 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ArrayAdapter._notifyDataSetChanged9877 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.ArrayAdapter._setNotifyOnChange9878 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V"); 
			global::android.widget.ArrayAdapter._setDropDownViewResource9879 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V"); 
			global::android.widget.ArrayAdapter._createFromResource9880 = @__env.GetStaticMethodID(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9881 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9882 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9883 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9884 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9885 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9886 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V"); 
		} 
	} 
} 
