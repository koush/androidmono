namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ViewDebug : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ViewDebug() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewDebug), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.ViewDebug(@__env); 
			} 
		} 
		protected ViewDebug(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface CapturedViewProperty : java.lang.annotation.Annotation
		{ 
			bool retrieveReturn(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ExportedProperty : java.lang.annotation.Annotation
		{ 
			java.lang.String prefix(); 
			bool resolveId(); 
			android.view.ViewDebug.IntToString[] mapping(); 
			android.view.ViewDebug.IntToString[] indexMapping(); 
			android.view.ViewDebug.FlagToString[] flagMapping(); 
			bool deepExport(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface FlagToString : java.lang.annotation.Annotation
		{ 
			java.lang.String name(); 
			int equals(); 
			int mask(); 
			bool outputIf(); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class HierarchyTraceType : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static HierarchyTraceType() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewDebug.HierarchyTraceType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewDebug.HierarchyTraceType(@__env); 
				} 
			} 
			internal HierarchyTraceType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7859; 
			public static android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewDebug.HierarchyTraceType>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.HierarchyTraceType.staticClass, _valueOf7859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values7860; 
			public static android.view.ViewDebug.HierarchyTraceType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.HierarchyTraceType.staticClass, _values7860)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BUILD_CACHE7861; 
			public static android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DRAW7862; 
			public static android.view.ViewDebug.HierarchyTraceType DRAW
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE7863; 
			public static android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE_CHILD7864; 
			public static android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE_CHILD_IN_PARENT7865; 
			public static android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ON_LAYOUT7866; 
			public static android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ON_MEASURE7867; 
			public static android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _REQUEST_LAYOUT7868; 
			public static android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.HierarchyTraceType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__class; 
				global::android.view.ViewDebug.HierarchyTraceType._valueOf7859 = @__env.GetStaticMethodID(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;"); 
				global::android.view.ViewDebug.HierarchyTraceType._values7860 = @__env.GetStaticMethodID(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface IntToString : java.lang.annotation.Annotation
		{ 
			int from(); 
			java.lang.String to(); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class RecyclerTraceType : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static RecyclerTraceType() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewDebug.RecyclerTraceType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewDebug.RecyclerTraceType(@__env); 
				} 
			} 
			internal RecyclerTraceType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7869; 
			public static android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewDebug.RecyclerTraceType>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.RecyclerTraceType.staticClass, _valueOf7869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values7870; 
			public static android.view.ViewDebug.RecyclerTraceType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.RecyclerTraceType.staticClass, _values7870)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BIND_VIEW7871; 
			public static android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP7872; 
			public static android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_TO_ACTIVE_HEAP7873; 
			public static android.view.ViewDebug.RecyclerTraceType MOVE_TO_ACTIVE_HEAP
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_TO_SCRAP_HEAP7874; 
			public static android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NEW_VIEW7875; 
			public static android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RECYCLE_FROM_ACTIVE_HEAP7876; 
			public static android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RECYCLE_FROM_SCRAP_HEAP7877; 
			public static android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{ 
				get 
				{ 
					return default(android.view.ViewDebug.RecyclerTraceType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__class; 
				global::android.view.ViewDebug.RecyclerTraceType._valueOf7869 = @__env.GetStaticMethodID(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;"); 
				global::android.view.ViewDebug.RecyclerTraceType._values7870 = @__env.GetStaticMethodID(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _trace7878; 
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _trace7878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _trace7879; 
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _trace7879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startRecyclerTracing7880; 
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _startRecyclerTracing7880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopRecyclerTracing7881; 
		public static void stopRecyclerTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _stopRecyclerTracing7881); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startHierarchyTracing7882; 
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _startHierarchyTracing7882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopHierarchyTracing7883; 
		public static void stopHierarchyTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _stopHierarchyTracing7883); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCapturedView7884; 
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, _dumpCapturedView7884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewDebug7885; 
		public ViewDebug()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewDebug.staticClass, _ViewDebug7885, this); 
		} 
		public static bool TRACE_HIERARCHY
		{ 
			get 
			{ 
				return false; 
			} 
		} 
		public static bool TRACE_RECYCLER
		{ 
			get 
			{ 
				return false; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ViewDebug.staticClass = @__class; 
			global::android.view.ViewDebug._trace7878 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V"); 
			global::android.view.ViewDebug._trace7879 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V"); 
			global::android.view.ViewDebug._startRecyclerTracing7880 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V"); 
			global::android.view.ViewDebug._stopRecyclerTracing7881 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V"); 
			global::android.view.ViewDebug._startHierarchyTracing7882 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V"); 
			global::android.view.ViewDebug._stopHierarchyTracing7883 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V"); 
			global::android.view.ViewDebug._dumpCapturedView7884 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V"); 
			global::android.view.ViewDebug._ViewDebug7885 = @__env.GetMethodID(global::android.view.ViewDebug.staticClass, "<init>", "()V"); 
		} 
	} 
} 
