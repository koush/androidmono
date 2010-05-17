namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class MediaStore : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MediaStore() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.MediaStore(@__env); 
			} 
		} 
		internal MediaStore(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Audio : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Audio() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.MediaStore.Audio(@__env); 
				} 
			} 
			internal Audio(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface AlbumColumns 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class AlbumColumnsConstants 
			{ 
				public static java.lang.String ALBUM_ID
				{ 
					get 
					{ 
						return "album_id"; 
					} 
				} 
				public static java.lang.String ALBUM
				{ 
					get 
					{ 
						return "album"; 
					} 
				} 
				public static java.lang.String ARTIST
				{ 
					get 
					{ 
						return "artist"; 
					} 
				} 
				public static java.lang.String NUMBER_OF_SONGS
				{ 
					get 
					{ 
						return "numsongs"; 
					} 
				} 
				public static java.lang.String NUMBER_OF_SONGS_FOR_ARTIST
				{ 
					get 
					{ 
						return "numsongs_by_artist"; 
					} 
				} 
				public static java.lang.String FIRST_YEAR
				{ 
					get 
					{ 
						return "minyear"; 
					} 
				} 
				public static java.lang.String LAST_YEAR
				{ 
					get 
					{ 
						return "maxyear"; 
					} 
				} 
				public static java.lang.String ALBUM_KEY
				{ 
					get 
					{ 
						return "album_key"; 
					} 
				} 
				public static java.lang.String ALBUM_ART
				{ 
					get 
					{ 
						return "album_art"; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Albums : java.lang.Object, BaseColumns, AlbumColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Albums() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Albums), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Audio.Albums(@__env); 
					} 
				} 
				internal Albums(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri5970; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Albums.staticClass, _getContentUri5970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Albums5971; 
				public Albums()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Audio.Albums.staticClass, _Albums5971, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI5972; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI5973; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/albums"; 
					} 
				} 
				public static java.lang.String ENTRY_CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/album"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "album_key"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Audio.Albums.staticClass = @__class; 
					global::android.provider.MediaStore.Audio.Albums._getContentUri5970 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Albums.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Audio.Albums._Albums5971 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Albums.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface ArtistColumns 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class ArtistColumnsConstants 
			{ 
				public static java.lang.String ARTIST
				{ 
					get 
					{ 
						return "artist"; 
					} 
				} 
				public static java.lang.String ARTIST_KEY
				{ 
					get 
					{ 
						return "artist_key"; 
					} 
				} 
				public static java.lang.String NUMBER_OF_ALBUMS
				{ 
					get 
					{ 
						return "number_of_albums"; 
					} 
				} 
				public static java.lang.String NUMBER_OF_TRACKS
				{ 
					get 
					{ 
						return "number_of_tracks"; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Artists : java.lang.Object, BaseColumns, ArtistColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Artists() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Artists), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Audio.Artists(@__env); 
					} 
				} 
				internal Artists(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
				public sealed class Albums : java.lang.Object, AlbumColumns
				{ 
					internal static global::java.lang.Class staticClass; 
					static Albums() 
					{ 
						global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Artists.Albums), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
					} 
					private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
					{ 
						public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
						{ 
							return new global::android.provider.MediaStore.Audio.Artists.Albums(@__env); 
						} 
					} 
					internal Albums(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
					{ 
					} 
					internal static global::net.sf.jni4net.jni.MethodId _getContentUri5974; 
					public static android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{ 
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
						return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Artists.Albums.staticClass, _getContentUri5974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
					} 
					internal static global::net.sf.jni4net.jni.MethodId _Albums5975; 
					public Albums()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
					{ 
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
						@__env.NewObject(android.provider.MediaStore.Audio.Artists.Albums.staticClass, _Albums5975, this); 
					} 
					private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
					{ 
						global::android.provider.MediaStore.Audio.Artists.Albums.staticClass = @__class; 
						global::android.provider.MediaStore.Audio.Artists.Albums._getContentUri5974 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;"); 
						global::android.provider.MediaStore.Audio.Artists.Albums._Albums5975 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "<init>", "()V"); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri5976; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Artists.staticClass, _getContentUri5976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Artists5977; 
				public Artists()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Audio.Artists.staticClass, _Artists5977, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI5978; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI5979; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/artists"; 
					} 
				} 
				public static java.lang.String ENTRY_CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/artist"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "artist_key"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Audio.Artists.staticClass = @__class; 
					global::android.provider.MediaStore.Audio.Artists._getContentUri5976 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Artists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Audio.Artists._Artists5977 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Artists.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface AudioColumns : MediaColumns
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class AudioColumnsConstants 
			{ 
				public static java.lang.String TITLE_KEY
				{ 
					get 
					{ 
						return "title_key"; 
					} 
				} 
				public static java.lang.String DURATION
				{ 
					get 
					{ 
						return "duration"; 
					} 
				} 
				public static java.lang.String ARTIST_ID
				{ 
					get 
					{ 
						return "artist_id"; 
					} 
				} 
				public static java.lang.String ARTIST
				{ 
					get 
					{ 
						return "artist"; 
					} 
				} 
				public static java.lang.String ARTIST_KEY
				{ 
					get 
					{ 
						return "artist_key"; 
					} 
				} 
				public static java.lang.String COMPOSER
				{ 
					get 
					{ 
						return "composer"; 
					} 
				} 
				public static java.lang.String ALBUM_ID
				{ 
					get 
					{ 
						return "album_id"; 
					} 
				} 
				public static java.lang.String ALBUM
				{ 
					get 
					{ 
						return "album"; 
					} 
				} 
				public static java.lang.String ALBUM_KEY
				{ 
					get 
					{ 
						return "album_key"; 
					} 
				} 
				public static java.lang.String ALBUM_ART
				{ 
					get 
					{ 
						return "album_art"; 
					} 
				} 
				public static java.lang.String TRACK
				{ 
					get 
					{ 
						return "track"; 
					} 
				} 
				public static java.lang.String YEAR
				{ 
					get 
					{ 
						return "year"; 
					} 
				} 
				public static java.lang.String IS_MUSIC
				{ 
					get 
					{ 
						return "is_music"; 
					} 
				} 
				public static java.lang.String IS_RINGTONE
				{ 
					get 
					{ 
						return "is_ringtone"; 
					} 
				} 
				public static java.lang.String IS_ALARM
				{ 
					get 
					{ 
						return "is_alarm"; 
					} 
				} 
				public static java.lang.String IS_NOTIFICATION
				{ 
					get 
					{ 
						return "is_notification"; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Genres : java.lang.Object, BaseColumns, GenresColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Genres() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Genres), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Audio.Genres(@__env); 
					} 
				} 
				internal Genres(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
				public sealed class Members : java.lang.Object, AudioColumns
				{ 
					internal static global::java.lang.Class staticClass; 
					static Members() 
					{ 
						global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Genres.Members), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
					} 
					private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
					{ 
						public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
						{ 
							return new global::android.provider.MediaStore.Audio.Genres.Members(@__env); 
						} 
					} 
					internal Members(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
					{ 
					} 
					internal static global::net.sf.jni4net.jni.MethodId _getContentUri5980; 
					public static android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{ 
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
						return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Genres.Members.staticClass, _getContentUri5980, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
					} 
					internal static global::net.sf.jni4net.jni.MethodId _Members5981; 
					public Members()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
					{ 
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
						@__env.NewObject(android.provider.MediaStore.Audio.Genres.Members.staticClass, _Members5981, this); 
					} 
					public static java.lang.String CONTENT_DIRECTORY
					{ 
						get 
						{ 
							return "members"; 
						} 
					} 
					public static java.lang.String DEFAULT_SORT_ORDER
					{ 
						get 
						{ 
							return "title_key"; 
						} 
					} 
					public static java.lang.String AUDIO_ID
					{ 
						get 
						{ 
							return "audio_id"; 
						} 
					} 
					public static java.lang.String GENRE_ID
					{ 
						get 
						{ 
							return "genre_id"; 
						} 
					} 
					private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
					{ 
						global::android.provider.MediaStore.Audio.Genres.Members.staticClass = @__class; 
						global::android.provider.MediaStore.Audio.Genres.Members._getContentUri5980 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;"); 
						global::android.provider.MediaStore.Audio.Genres.Members._Members5981 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "<init>", "()V"); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri5982; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Genres.staticClass, _getContentUri5982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Genres5983; 
				public Genres()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Audio.Genres.staticClass, _Genres5983, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI5984; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI5985; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/genre"; 
					} 
				} 
				public static java.lang.String ENTRY_CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/genre"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "name"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Audio.Genres.staticClass = @__class; 
					global::android.provider.MediaStore.Audio.Genres._getContentUri5982 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Genres.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Audio.Genres._Genres5983 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Genres.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface GenresColumns 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class GenresColumnsConstants 
			{ 
				public static java.lang.String NAME
				{ 
					get 
					{ 
						return "name"; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Media : java.lang.Object, AudioColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Media() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Media), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Audio.Media(@__env); 
					} 
				} 
				internal Media(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri5986; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Media.staticClass, _getContentUri5986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUriForPath5987; 
				public static android.net.Uri getContentUriForPath(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Media.staticClass, _getContentUriForPath5987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Media5988; 
				public Media()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Audio.Media.staticClass, _Media5988, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI5989; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI5990; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/audio"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "title_key"; 
					} 
				} 
				public static java.lang.String RECORD_SOUND_ACTION
				{ 
					get 
					{ 
						return "android.provider.MediaStore.RECORD_SOUND"; 
					} 
				} 
				public static java.lang.String EXTRA_MAX_BYTES
				{ 
					get 
					{ 
						return "android.provider.MediaStore.extra.MAX_BYTES"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Audio.Media.staticClass = @__class; 
					global::android.provider.MediaStore.Audio.Media._getContentUri5986 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Audio.Media._getContentUriForPath5987 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUriForPath", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Audio.Media._Media5988 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Media.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Playlists : java.lang.Object, BaseColumns, PlaylistsColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Playlists() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Playlists), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Audio.Playlists(@__env); 
					} 
				} 
				internal Playlists(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
				public sealed class Members : java.lang.Object, AudioColumns
				{ 
					internal static global::java.lang.Class staticClass; 
					static Members() 
					{ 
						global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Audio.Playlists.Members), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
					} 
					private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
					{ 
						public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
						{ 
							return new global::android.provider.MediaStore.Audio.Playlists.Members(@__env); 
						} 
					} 
					internal Members(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
					{ 
					} 
					internal static global::net.sf.jni4net.jni.MethodId _getContentUri5991; 
					public static android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{ 
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
						return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Playlists.Members.staticClass, _getContentUri5991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
					} 
					internal static global::net.sf.jni4net.jni.MethodId _Members5992; 
					public Members()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
					{ 
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
						@__env.NewObject(android.provider.MediaStore.Audio.Playlists.Members.staticClass, _Members5992, this); 
					} 
					public static java.lang.String _ID
					{ 
						get 
						{ 
							return "_id"; 
						} 
					} 
					public static java.lang.String CONTENT_DIRECTORY
					{ 
						get 
						{ 
							return "members"; 
						} 
					} 
					public static java.lang.String AUDIO_ID
					{ 
						get 
						{ 
							return "audio_id"; 
						} 
					} 
					public static java.lang.String PLAYLIST_ID
					{ 
						get 
						{ 
							return "playlist_id"; 
						} 
					} 
					public static java.lang.String PLAY_ORDER
					{ 
						get 
						{ 
							return "play_order"; 
						} 
					} 
					public static java.lang.String DEFAULT_SORT_ORDER
					{ 
						get 
						{ 
							return "play_order"; 
						} 
					} 
					private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
					{ 
						global::android.provider.MediaStore.Audio.Playlists.Members.staticClass = @__class; 
						global::android.provider.MediaStore.Audio.Playlists.Members._getContentUri5991 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;"); 
						global::android.provider.MediaStore.Audio.Playlists.Members._Members5992 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "<init>", "()V"); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri5993; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Playlists.staticClass, _getContentUri5993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Playlists5994; 
				public Playlists()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Audio.Playlists.staticClass, _Playlists5994, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI5995; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI5996; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/playlist"; 
					} 
				} 
				public static java.lang.String ENTRY_CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/playlist"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "name"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Audio.Playlists.staticClass = @__class; 
					global::android.provider.MediaStore.Audio.Playlists._getContentUri5993 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Playlists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Audio.Playlists._Playlists5994 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Playlists.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface PlaylistsColumns 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class PlaylistsColumnsConstants 
			{ 
				public static java.lang.String NAME
				{ 
					get 
					{ 
						return "name"; 
					} 
				} 
				public static java.lang.String DATA
				{ 
					get 
					{ 
						return "_data"; 
					} 
				} 
				public static java.lang.String DATE_ADDED
				{ 
					get 
					{ 
						return "date_added"; 
					} 
				} 
				public static java.lang.String DATE_MODIFIED
				{ 
					get 
					{ 
						return "date_modified"; 
					} 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _keyFor5997; 
			public static java.lang.String keyFor(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.staticClass, _keyFor5997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Audio5998; 
			public Audio()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.MediaStore.Audio.staticClass, _Audio5998, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.MediaStore.Audio.staticClass = @__class; 
				global::android.provider.MediaStore.Audio._keyFor5997 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.staticClass, "keyFor", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.MediaStore.Audio._Audio5998 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Images : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Images() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Images), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.MediaStore.Images(@__env); 
				} 
			} 
			internal Images(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface ImageColumns : MediaColumns
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class ImageColumnsConstants 
			{ 
				public static java.lang.String DESCRIPTION
				{ 
					get 
					{ 
						return "description"; 
					} 
				} 
				public static java.lang.String PICASA_ID
				{ 
					get 
					{ 
						return "picasa_id"; 
					} 
				} 
				public static java.lang.String IS_PRIVATE
				{ 
					get 
					{ 
						return "isprivate"; 
					} 
				} 
				public static java.lang.String LATITUDE
				{ 
					get 
					{ 
						return "latitude"; 
					} 
				} 
				public static java.lang.String LONGITUDE
				{ 
					get 
					{ 
						return "longitude"; 
					} 
				} 
				public static java.lang.String DATE_TAKEN
				{ 
					get 
					{ 
						return "datetaken"; 
					} 
				} 
				public static java.lang.String ORIENTATION
				{ 
					get 
					{ 
						return "orientation"; 
					} 
				} 
				public static java.lang.String MINI_THUMB_MAGIC
				{ 
					get 
					{ 
						return "mini_thumb_magic"; 
					} 
				} 
				public static java.lang.String BUCKET_ID
				{ 
					get 
					{ 
						return "bucket_id"; 
					} 
				} 
				public static java.lang.String BUCKET_DISPLAY_NAME
				{ 
					get 
					{ 
						return "bucket_display_name"; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Media : java.lang.Object, ImageColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Media() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Images.Media), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Images.Media(@__env); 
					} 
				} 
				internal Media(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _query5999; 
				public static android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _query5999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _query6000; 
				public static android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _query6000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _query6001; 
				public static android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _query6001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getBitmap6002; 
				public static android.graphics.Bitmap getBitmap(android.content.ContentResolver arg0, android.net.Uri arg1) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _getBitmap6002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6003; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _getContentUri6003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _insertImage6004; 
				public static java.lang.String insertImage(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _insertImage6004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _insertImage6005; 
				public static java.lang.String insertImage(android.content.ContentResolver arg0, android.graphics.Bitmap arg1, java.lang.String arg2, java.lang.String arg3) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, _insertImage6005, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Media6006; 
				public Media()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Images.Media.staticClass, _Media6006, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6007; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6008; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/image"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "bucket_display_name"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Images.Media.staticClass = @__class; 
					global::android.provider.MediaStore.Images.Media._query5999 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;"); 
					global::android.provider.MediaStore.Images.Media._query6000 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
					global::android.provider.MediaStore.Images.Media._query6001 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
					global::android.provider.MediaStore.Images.Media._getBitmap6002 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "getBitmap", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/graphics/Bitmap;"); 
					global::android.provider.MediaStore.Images.Media._getContentUri6003 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Images.Media._insertImage6004 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
					global::android.provider.MediaStore.Images.Media._insertImage6005 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
					global::android.provider.MediaStore.Images.Media._Media6006 = @__env.GetMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public class Thumbnails : java.lang.Object, BaseColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Thumbnails() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Images.Thumbnails), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Images.Thumbnails(@__env); 
					} 
				} 
				protected Thumbnails(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _query6009; 
				public static android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, _query6009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getThumbnail6010; 
				public static android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, _getThumbnail6010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6011; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, _getContentUri6011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _queryMiniThumbnails6012; 
				public static android.database.Cursor queryMiniThumbnails(android.content.ContentResolver arg0, android.net.Uri arg1, int arg2, java.lang.String[] arg3) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, _queryMiniThumbnails6012, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _queryMiniThumbnail6013; 
				public static android.database.Cursor queryMiniThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, java.lang.String[] arg3) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, _queryMiniThumbnail6013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _cancelThumbnailRequest6014; 
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, _cancelThumbnailRequest6014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Thumbnails6015; 
				public Thumbnails()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Images.Thumbnails.staticClass, _Thumbnails6015, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6016; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6017; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "image_id ASC"; 
					} 
				} 
				public static java.lang.String DATA
				{ 
					get 
					{ 
						return "_data"; 
					} 
				} 
				public static java.lang.String IMAGE_ID
				{ 
					get 
					{ 
						return "image_id"; 
					} 
				} 
				public static java.lang.String KIND
				{ 
					get 
					{ 
						return "kind"; 
					} 
				} 
				public static int MINI_KIND
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int FULL_SCREEN_KIND
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int MICRO_KIND
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static java.lang.String THUMB_DATA
				{ 
					get 
					{ 
						return "thumb_data"; 
					} 
				} 
				public static java.lang.String WIDTH
				{ 
					get 
					{ 
						return "width"; 
					} 
				} 
				public static java.lang.String HEIGHT
				{ 
					get 
					{ 
						return "height"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Images.Thumbnails.staticClass = @__class; 
					global::android.provider.MediaStore.Images.Thumbnails._query6009 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;"); 
					global::android.provider.MediaStore.Images.Thumbnails._getThumbnail6010 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
					global::android.provider.MediaStore.Images.Thumbnails._getContentUri6011 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnails6012 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnails", "(Landroid/content/ContentResolver;Landroid/net/Uri;I[Ljava/lang/String;)Landroid/database/Cursor;"); 
					global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnail6013 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnail", "(Landroid/content/ContentResolver;JI[Ljava/lang/String;)Landroid/database/Cursor;"); 
					global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest6014 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V"); 
					global::android.provider.MediaStore.Images.Thumbnails._Thumbnails6015 = @__env.GetMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "<init>", "()V"); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Images6018; 
			public Images()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.MediaStore.Images.staticClass, _Images6018, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.MediaStore.Images.staticClass = @__class; 
				global::android.provider.MediaStore.Images._Images6018 = @__env.GetMethodID(global::android.provider.MediaStore.Images.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface MediaColumns : BaseColumns
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class MediaColumnsConstants 
		{ 
			public static java.lang.String DATA
			{ 
				get 
				{ 
					return "_data"; 
				} 
			} 
			public static java.lang.String SIZE
			{ 
				get 
				{ 
					return "_size"; 
				} 
			} 
			public static java.lang.String DISPLAY_NAME
			{ 
				get 
				{ 
					return "_display_name"; 
				} 
			} 
			public static java.lang.String TITLE
			{ 
				get 
				{ 
					return "title"; 
				} 
			} 
			public static java.lang.String DATE_ADDED
			{ 
				get 
				{ 
					return "date_added"; 
				} 
			} 
			public static java.lang.String DATE_MODIFIED
			{ 
				get 
				{ 
					return "date_modified"; 
				} 
			} 
			public static java.lang.String MIME_TYPE
			{ 
				get 
				{ 
					return "mime_type"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Video : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Video() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Video), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.MediaStore.Video(@__env); 
				} 
			} 
			internal Video(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Media : java.lang.Object, VideoColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Media() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Video.Media), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Video.Media(@__env); 
					} 
				} 
				internal Media(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6019; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Media.staticClass, _getContentUri6019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Media6020; 
				public Media()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Video.Media.staticClass, _Media6020, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6021; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6022; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/video"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "title"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Video.Media.staticClass = @__class; 
					global::android.provider.MediaStore.Video.Media._getContentUri6019 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Video.Media._Media6020 = @__env.GetMethodID(global::android.provider.MediaStore.Video.Media.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public class Thumbnails : java.lang.Object, BaseColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Thumbnails() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.MediaStore.Video.Thumbnails), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.MediaStore.Video.Thumbnails(@__env); 
					} 
				} 
				protected Thumbnails(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getThumbnail6023; 
				public static android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Thumbnails.staticClass, _getThumbnail6023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6024; 
				public static android.net.Uri getContentUri(java.lang.String arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Thumbnails.staticClass, _getContentUri6024, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _cancelThumbnailRequest6025; 
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, _cancelThumbnailRequest6025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Thumbnails6026; 
				public Thumbnails()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.MediaStore.Video.Thumbnails.staticClass, _Thumbnails6026, this); 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6027; 
				public static android.net.Uri INTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6028; 
				public static android.net.Uri EXTERNAL_CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "video_id ASC"; 
					} 
				} 
				public static java.lang.String DATA
				{ 
					get 
					{ 
						return "_data"; 
					} 
				} 
				public static java.lang.String VIDEO_ID
				{ 
					get 
					{ 
						return "video_id"; 
					} 
				} 
				public static java.lang.String KIND
				{ 
					get 
					{ 
						return "kind"; 
					} 
				} 
				public static int MINI_KIND
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int FULL_SCREEN_KIND
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int MICRO_KIND
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static java.lang.String WIDTH
				{ 
					get 
					{ 
						return "width"; 
					} 
				} 
				public static java.lang.String HEIGHT
				{ 
					get 
					{ 
						return "height"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.MediaStore.Video.Thumbnails.staticClass = @__class; 
					global::android.provider.MediaStore.Video.Thumbnails._getThumbnail6023 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
					global::android.provider.MediaStore.Video.Thumbnails._getContentUri6024 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;"); 
					global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest6025 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V"); 
					global::android.provider.MediaStore.Video.Thumbnails._Thumbnails6026 = @__env.GetMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface VideoColumns : MediaColumns
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class VideoColumnsConstants 
			{ 
				public static java.lang.String DURATION
				{ 
					get 
					{ 
						return "duration"; 
					} 
				} 
				public static java.lang.String ARTIST
				{ 
					get 
					{ 
						return "artist"; 
					} 
				} 
				public static java.lang.String ALBUM
				{ 
					get 
					{ 
						return "album"; 
					} 
				} 
				public static java.lang.String RESOLUTION
				{ 
					get 
					{ 
						return "resolution"; 
					} 
				} 
				public static java.lang.String DESCRIPTION
				{ 
					get 
					{ 
						return "description"; 
					} 
				} 
				public static java.lang.String IS_PRIVATE
				{ 
					get 
					{ 
						return "isprivate"; 
					} 
				} 
				public static java.lang.String TAGS
				{ 
					get 
					{ 
						return "tags"; 
					} 
				} 
				public static java.lang.String CATEGORY
				{ 
					get 
					{ 
						return "category"; 
					} 
				} 
				public static java.lang.String LANGUAGE
				{ 
					get 
					{ 
						return "language"; 
					} 
				} 
				public static java.lang.String LATITUDE
				{ 
					get 
					{ 
						return "latitude"; 
					} 
				} 
				public static java.lang.String LONGITUDE
				{ 
					get 
					{ 
						return "longitude"; 
					} 
				} 
				public static java.lang.String DATE_TAKEN
				{ 
					get 
					{ 
						return "datetaken"; 
					} 
				} 
				public static java.lang.String MINI_THUMB_MAGIC
				{ 
					get 
					{ 
						return "mini_thumb_magic"; 
					} 
				} 
				public static java.lang.String BUCKET_ID
				{ 
					get 
					{ 
						return "bucket_id"; 
					} 
				} 
				public static java.lang.String BUCKET_DISPLAY_NAME
				{ 
					get 
					{ 
						return "bucket_display_name"; 
					} 
				} 
				public static java.lang.String BOOKMARK
				{ 
					get 
					{ 
						return "bookmark"; 
					} 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _query6029; 
			public static android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.staticClass, _query6029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Video6030; 
			public Video()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.MediaStore.Video.staticClass, _Video6030, this); 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "_display_name"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.MediaStore.Video.staticClass = @__class; 
				global::android.provider.MediaStore.Video._query6029 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;"); 
				global::android.provider.MediaStore.Video._Video6030 = @__env.GetMethodID(global::android.provider.MediaStore.Video.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMediaScannerUri6031; 
		public static android.net.Uri getMediaScannerUri() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.staticClass, _getMediaScannerUri6031)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaStore6032; 
		public MediaStore()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.MediaStore.staticClass, _MediaStore6032, this); 
		} 
		public static java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "media"; 
			} 
		} 
		public static java.lang.String INTENT_ACTION_MEDIA_SEARCH
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_SEARCH"; 
			} 
		} 
		public static java.lang.String EXTRA_MEDIA_ARTIST
		{ 
			get 
			{ 
				return "android.intent.extra.artist"; 
			} 
		} 
		public static java.lang.String EXTRA_MEDIA_ALBUM
		{ 
			get 
			{ 
				return "android.intent.extra.album"; 
			} 
		} 
		public static java.lang.String EXTRA_MEDIA_TITLE
		{ 
			get 
			{ 
				return "android.intent.extra.title"; 
			} 
		} 
		public static java.lang.String EXTRA_MEDIA_FOCUS
		{ 
			get 
			{ 
				return "android.intent.extra.focus"; 
			} 
		} 
		public static java.lang.String EXTRA_SCREEN_ORIENTATION
		{ 
			get 
			{ 
				return "android.intent.extra.screenOrientation"; 
			} 
		} 
		public static java.lang.String EXTRA_FINISH_ON_COMPLETION
		{ 
			get 
			{ 
				return "android.intent.extra.finishOnCompletion"; 
			} 
		} 
		public static java.lang.String INTENT_ACTION_STILL_IMAGE_CAMERA
		{ 
			get 
			{ 
				return "android.media.action.STILL_IMAGE_CAMERA"; 
			} 
		} 
		public static java.lang.String INTENT_ACTION_VIDEO_CAMERA
		{ 
			get 
			{ 
				return "android.media.action.VIDEO_CAMERA"; 
			} 
		} 
		public static java.lang.String ACTION_IMAGE_CAPTURE
		{ 
			get 
			{ 
				return "android.media.action.IMAGE_CAPTURE"; 
			} 
		} 
		public static java.lang.String ACTION_VIDEO_CAPTURE
		{ 
			get 
			{ 
				return "android.media.action.VIDEO_CAPTURE"; 
			} 
		} 
		public static java.lang.String EXTRA_VIDEO_QUALITY
		{ 
			get 
			{ 
				return "android.intent.extra.videoQuality"; 
			} 
		} 
		public static java.lang.String EXTRA_OUTPUT
		{ 
			get 
			{ 
				return "output"; 
			} 
		} 
		public static java.lang.String MEDIA_SCANNER_VOLUME
		{ 
			get 
			{ 
				return "volume"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.MediaStore.staticClass = @__class; 
			global::android.provider.MediaStore._getMediaScannerUri6031 = @__env.GetStaticMethodID(global::android.provider.MediaStore.staticClass, "getMediaScannerUri", "()Landroid/net/Uri;"); 
			global::android.provider.MediaStore._MediaStore6032 = @__env.GetMethodID(global::android.provider.MediaStore.staticClass, "<init>", "()V"); 
		} 
	} 
} 
